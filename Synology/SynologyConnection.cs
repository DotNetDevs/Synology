using System;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using Synology.Classes;
using System.Threading.Tasks;
using Synology.Utilities;
using Autofac;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using NLog;

namespace Synology
{
    public class SynologyConnection : IDisposable
    {
        private readonly HttpClient _client;
        public readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public string Sid { private get; set; }

        private readonly IContainer _container;
        private readonly ILifetimeScope _containerScope;

        public SynologyConnection(string baseHost, bool ssl = false, int port = 5000, int sslPort = 5001)
        {
            // Remove Expect: 100-continue header.
            ServicePointManager.Expect100Continue = false;

            var sslPostfix = ssl ? "s" : string.Empty;
            var usedPort = ssl ? sslPort : port;

            Logger.Debug($"Creating new connection to {baseHost} with{(ssl ? "" : "out")} SSL to port {usedPort}");

            _client = new HttpClient
            {
                BaseAddress = new Uri($"http{sslPostfix}://{baseHost}:{usedPort}/webapi/")
            };

            var builder = new ContainerBuilder();

            builder.RegisterInstance(this).As<SynologyConnection>();

            _container = builder.Build();

            _containerScope = _container.BeginLifetimeScope();
        }

        private void RegisterApi<T>() where T : SynologyApi
        {
            Logger.Debug($"Registering API {typeof(T).Name}");

            var builder = new ContainerBuilder();

            builder.RegisterType<T>().AsSelf().As<SynologyApi>();
            builder.Update(_container);
        }

        private void RegisterRequest<T>() where T : SynologyRequest
        {
            Logger.Debug($"Registering Request {typeof(T).Name}");

            var builder = new ContainerBuilder();

            string apiName;

            try
            {
                var request = Activator.CreateInstance<T>();

                apiName = request.ApiName;
            }
            catch (Exception)
            {
                apiName = null;
            }

            if (!string.IsNullOrEmpty(apiName))
                builder.RegisterType<T>().Named<SynologyRequest>(apiName).Named<T>(apiName).AsSelf().As<SynologyRequest>();
            else
                builder.RegisterType<T>().AsSelf().As<SynologyRequest>();
            builder.Update(_container);
        }

        private T ResolveRequest<T>() where T : SynologyRequest
        {
            T res;

            if (!_container.TryResolve(out res))
            {
                RegisterRequest<T>();

                return ResolveRequest<T>();
            }

            return res;
        }

        private SynologyRequest ResolveRequest(string name) => ResolveRequest<SynologyRequest>(name);

        private T ResolveRequest<T>(string name) where T : SynologyRequest
        {
            object req;

            if (!_container.TryResolveNamed(name, typeof(T), out req))
            {
                req = null;
            }

            return req as T;
        }

        private T ResolveApi<T>() where T : SynologyApi
        {
            T res;

            if (!_container.TryResolve(out res))
            {
                RegisterApi<T>();

                return ResolveApi<T>();
            }

            return res;
        }

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
            }));

            var res = url.ToString();

            Logger.Debug($"Created API Url for GET: {res}");

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

            Logger.Debug($"Created API Url for POST: {res}");

            return new Uri(_client.BaseAddress, res);
        }

        private async Task<T> GenericGetDataFromApiAsync<T>(string cgi, string api, int version, string method, QueryStringParameter[] additionalParams = null) where T : ResultData => JsonConvert.DeserializeObject<T>(await _client.GetStringAsync(GetApiUrl(cgi, api, version, method, additionalParams)));

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
            }.Concat(additionalParams ?? new FormParameter[] { }).ToArray();

            using (var content = new FormParameterManager(allParameters))
            {
                var formContent = await content.ToByteArrayAsync();

                using (var requestContent = new ByteArrayContent(formContent))
                {
                    requestContent.Headers.ContentType = new MediaTypeHeaderValue(content.MultipartContent.Headers.ContentType.ToString().Replace("\"", string.Empty));

                    var result = await _client.PostAsync(uri, requestContent);
                    var data = await result.Content.ReadAsByteArrayAsync();

                    return JsonConvert.DeserializeObject<T>(Encoding.Default.GetString(data));
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
            Logger.Debug("Closing connection");
            _client?.Dispose();
            _containerScope?.Dispose();
        }
    }
}