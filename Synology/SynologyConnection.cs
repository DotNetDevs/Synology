using System;
using System.Linq;
using Newtonsoft.Json;
using Synology.Classes;
using System.Threading.Tasks;
using Synology.Utilities;
using Autofac;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using Microsoft.Extensions.Logging;
using Synology.Interfaces;
using Synology.Settings;

namespace Synology
{
    public sealed class SynologyConnection : IDisposable
    {
        private readonly HttpClient _client;
        public readonly ILogger Logger;

        public string Sid { private get; set; }

        private readonly IContainer _container;
        private readonly ILifetimeScope _containerScope;

        public ISynologyConnectionSettings Settings { get; }

        public static SynologyConnection Create(ISynologyConnectionSettings settings)
        {
            return new SynologyConnection(settings);
        }

        [Obsolete("Use the new SynologyConnectionSettings class instead.")]
        public SynologyConnection(string baseHost, bool ssl = false, int port = 5000, int sslPort = 5001) : this(new SynologyConnectionSettings(baseHost, null, null, ssl, port, sslPort))
        {
        }

        public SynologyConnection(ISynologyConnectionSettings settings)
        {
            Settings = settings;

            var factory = new LoggerFactory();
            Logger = factory.CreateLogger<SynologyConnection>();

            Logger.LogDebug($"Creating new connection to {Settings.BaseHost} with{(Settings.SslEnabled ? "" : "out")} SSL to port {Settings.Port}");

            _client = new HttpClient
            {
                BaseAddress = new Uri(Settings.WebApiUrl),
            };

            _client.DefaultRequestHeaders.ExpectContinue = false;

            var builder = new ContainerBuilder();

            builder.RegisterInstance(this).As<SynologyConnection>();
            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies()).Where(a => a.Assembly.GetTypes().Any(t => t.IsAssignableTo<SynologyApi>())).AsSelf().As<SynologyApi>();
            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies()).Where(a => a.Assembly.GetTypes().Any(t => t.IsAssignableTo<SynologyRequest>())).AsSelf().As<SynologyRequest>();

            _container = builder.Build();

            _containerScope = _container.BeginLifetimeScope();
        }

        private T ResolveRequest<T>() where T : SynologyRequest => _container.TryResolve(out T res) ? res : default(T);

        private SynologyRequest ResolveRequest(string name) => ResolveRequest<SynologyRequest>(name);

        private T ResolveRequest<T>(string name) where T : SynologyRequest => _container.TryResolveNamed(name, typeof(T), out object req) ? req as T : default(T);

        private T ResolveApi<T>() where T : SynologyApi => _container.TryResolve(out T res) ? res : default(T);

        internal SynologyRequest Request(string name) => ResolveRequest(name);

        internal SynologyRequest Request<T>(string name) where T : SynologyRequest => ResolveRequest<T>(name);

        internal T Request<T>() where T : SynologyRequest => ResolveRequest<T>();

        internal T Api<T>() where T : SynologyApi => ResolveApi<T>();

        private string GetApiUrl(string cgi, string api, int version, string method, QueryStringParameter[] additionalParams = null)
        {
            var url = new QueryStringManager(cgi);

            additionalParams = additionalParams ?? new QueryStringParameter[] { };

            url.AddParameters(additionalParams.Concat(new[] {
                new QueryStringParameter("_sid", Sid),
                new QueryStringParameter("api", api),
                new QueryStringParameter("version", version),
                new QueryStringParameter("method", method)
            }).Where(t => t.MinVersion <= version));

            var res = url.ToString();

            Logger.LogDebug($"Created API Url for GET: {res}");

            return res;
        }

        /// <summary>
        /// Get Uri for post operations
        /// </summary>
        /// <param name="cgi">CGI path handling the request</param>
        /// <param name="api">API name handling the request</param>
        /// <param name="version">Version of the api</param>
        /// <param name="method">Method of the API</param>
        /// <returns>The Uri object where the request has to be sent</returns>
        private Uri PostApiUrl(string cgi, string api, int version, string method)
        {
            var url = new QueryStringManager(cgi);

            url.AddParameters(new[] {
                new QueryStringParameter("_sid", Sid),
            });

            var res = url.ToString();

            Logger.LogDebug($"Created API Url for POST: {res}");

            return new Uri(_client.BaseAddress, res);
        }

        private async Task<T> GenericGetDataFromApiAsync<T>(string cgi, string api, int version, string method, QueryStringParameter[] additionalParams = null) where T : ResultData
        {
            using (var reader = new StreamReader(await _client.GetStreamAsync(GetApiUrl(cgi, api, version, method, additionalParams))))
            {
                var json = await reader.ReadToEndAsync();

                Logger.LogDebug($"Response JSON for {api} v.{version} with method {method} [cgi: {cgi}]: {json}");

                return JsonConvert.DeserializeObject<T>(json);
            }
        }

        internal ResultData GetDataFromApi(string cgi, string api, int version, string method, QueryStringParameter[] additionalParams = null) => GetDataFromApiAsync(cgi, api, version, method, additionalParams).Result;

        internal ResultData<T> GetDataFromApi<T>(string cgi, string api, int version, string method, QueryStringParameter[] additionalParams = null) => GetDataFromApiAsync<T>(cgi, api, version, method, additionalParams).Result;

        internal async Task<ResultData<T>> GetDataFromApiAsync<T>(string cgi, string api, int version, string method, QueryStringParameter[] additionalParams = null) => await GenericGetDataFromApiAsync<ResultData<T>>(cgi, api, version, method, additionalParams);

        internal async Task<ResultData> GetDataFromApiAsync(string cgi, string api, int version, string method, QueryStringParameter[] additionalParams = null) => await GenericGetDataFromApiAsync<ResultData>(cgi, api, version, method, additionalParams);

        private async Task<T> GenericPostDataFromApiAsync<T>(string cgi, string api, int version, string method, FormParameter[] additionalParams = null) where T : ResultData
        {
            var uri = PostApiUrl(cgi, api, version, method);

            var allParameters = new[] {
                new FormParameter("api", api),
                new FormParameter("version", version),
                new FormParameter("method", method)
            }.Concat(additionalParams ?? new FormParameter[] { }).Where(t => t.MinVersion <= version).ToArray();

            using (var content = new FormParameterManager(allParameters))
            {
                var formContent = await content.ToByteArrayAsync();

                using (var requestContent = new ByteArrayContent(formContent))
                {
                    requestContent.Headers.ContentType = new MediaTypeHeaderValue(content.MultipartContent.Headers.ContentType.ToString().Replace("\"", string.Empty));

                    var result = await _client.PostAsync(uri, requestContent);
                    var data = await result.Content.ReadAsByteArrayAsync();

                    return JsonConvert.DeserializeObject<T>(Encoding.UTF8.GetString(data));
                }
            }
        }

        /// <summary>
        /// Performs an asynchronous post request to the Synology API
        /// </summary>
        /// <param name="cgi">CGI path handling the request</param>
        /// <param name="api">API name handling the request</param>
        /// <param name="version">Version of the api</param>
        /// <param name="method">Method of the API</param>
        /// <param name="additionalParams">Parameters of the request</param>
        /// <returns>Result of the request</returns>
        internal async Task<ResultData> PostDataFromApiAsync(string cgi, string api, int version, string method, FormParameter[] additionalParams = null) => await GenericPostDataFromApiAsync<ResultData>(cgi, api, version, method, additionalParams);

        /// <summary>
        /// Performs an asynchronous post request to the Synology API
        /// </summary>
        /// <typeparam name="T">Type of result</typeparam>
        /// <param name="cgi">CGI path handling the request</param>
        /// <param name="api">API name handling the request</param>
        /// <param name="version">Version of the api</param>
        /// <param name="method">Method of the API</param>
        /// <param name="additionalParams">Parameters of the request</param>
        /// <returns>Result of the request and the specific API/Method response</returns>
        internal async Task<ResultData<T>> PostDataFromApiAsync<T>(string cgi, string api, int version, string method, FormParameter[] additionalParams = null) => await GenericPostDataFromApiAsync<ResultData<T>>(cgi, api, version, method, additionalParams);

        /// <summary>
        /// Performs a post request to the Synology API
        /// </summary>
        /// <param name="cgi">CGI path handling the request</param>
        /// <param name="api">API name handling the request</param>
        /// <param name="version">Version of the api</param>
        /// <param name="method">Method of the API</param>
        /// <param name="additionalParams">Parameters of the request</param>
        /// <returns>Result of the request</returns>
        internal ResultData PostDataFromApi(string cgi, string api, int version, string method, FormParameter[] additionalParams = null) => PostDataFromApiAsync(cgi, api, version, method, additionalParams).Result;

        /// <summary>
        /// Performs a post request to the Synology API
        /// </summary>
        /// <typeparam name="T">Type of result</typeparam>
        /// <param name="cgi">CGI path handling the request</param>
        /// <param name="api">API name handling the request</param>
        /// <param name="version">Version of the api</param>
        /// <param name="method">Method of the API</param>
        /// <param name="additionalParams">Parameters of the request</param>
        /// <returns>Result of the request and the specific API/Method response</returns>
        internal ResultData<T> PostDataFromApi<T>(string cgi, string api, int version, string method, FormParameter[] additionalParams = null) => PostDataFromApiAsync<T>(cgi, api, version, method, additionalParams).Result;

        public void Dispose()
        {
            Logger.LogDebug("Closing connection");
            _client?.Dispose();
            _container?.Dispose();
            _containerScope?.Dispose();
        }
    }
}