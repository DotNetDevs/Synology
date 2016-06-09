﻿using System;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using Synology.Classes;
using System.Threading.Tasks;
using Synology.Utilities;
using Autofac;
using System.Net.Http;

namespace Synology
{
    public class SynologyConnection : IDisposable
    {
        private readonly WebClient _client;

        public string Sid { private get; set; }

        private readonly IContainer _container;
        private readonly ILifetimeScope _containerScope;

        public SynologyConnection(string baseHost, bool ssl = false, int port = 5000, int sslPort = 5001)
        {
            // Remove Expect: 100-continue header.
            ServicePointManager.Expect100Continue = false;

            var sslPostfix = ssl ? "s" : string.Empty;
            var usedPort = ssl ? sslPort : port;

            _client = new WebClient
            {
                BaseAddress = $"http{sslPostfix}://{baseHost}:{usedPort}/webapi/"
            };

            var builder = new ContainerBuilder();

            builder.RegisterInstance(this).As<SynologyConnection>();

            _container = builder.Build();

            _containerScope = _container.BeginLifetimeScope();
        }

        private void RegisterApi<T>() where T : SynologyApi
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<T>().AsSelf().As<SynologyApi>();
            builder.Update(_container);
        }

        private void RegisterRequest<T>() where T : SynologyRequest
        {
            var builder = new ContainerBuilder();

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

        internal T Request<T>() where T : SynologyRequest
        {
            return ResolveRequest<T>();
        }

        internal T Api<T>() where T : SynologyApi
        {
            return ResolveApi<T>();
        }

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

            return url.ToString();
        }

        /// <summary>
        /// Get Uri for post operations
        /// </summary>
        /// <param name="cgi">CGI path handling the request</param>
        /// <param name="api">API name handling the request</param>
        /// <param name="version">Version of the api</param>
        /// <param name="method">Method of the API</param>
        /// <returns>The Uri object where the request has to be sent</returns>
        private Uri GetPostApiUrl(string cgi,string api, int version, string method)
        {
            var url = new QueryStringManager(cgi);

            url.AddParameters(new[] {
                new QueryStringParameter("_sid", Sid),
            });

            return new Uri(new Uri(_client.BaseAddress), url.ToString());
        }

        internal ResultData GetDataFromApi(string cgi, string api, int version, string method, QueryStringParameter[] additionalParams = null)
        {
            return JsonConvert.DeserializeObject<ResultData>(_client.DownloadString(GetApiUrl(cgi, api, version, method, additionalParams)));
        }

        internal ResultData<T> GetDataFromApi<T>(string cgi, string api, int version, string method, QueryStringParameter[] additionalParams = null)
        {
            return JsonConvert.DeserializeObject<ResultData<T>>(_client.DownloadString(GetApiUrl(cgi, api, version, method, additionalParams)));
        }

        internal async Task<ResultData<T>> GetDataFromApiAsync<T>(string cgi, string api, int version, string method, QueryStringParameter[] additionalParams = null)
        {
            return JsonConvert.DeserializeObject<ResultData<T>>(await _client.DownloadStringTaskAsync(GetApiUrl(cgi, api, version, method, additionalParams)));
        }

        internal async Task<ResultData> GetDataFromApiAsync(string cgi, string api, int version, string method, QueryStringParameter[] additionalParams = null)
        {
            return JsonConvert.DeserializeObject<ResultData>(await _client.DownloadStringTaskAsync(GetApiUrl(cgi, api, version, method, additionalParams)));
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
        internal async Task<ResultData> PostDataFromApiAsync(string cgi, string api, int version, string method, FormParameter[] additionalParams = null)
        {
            Uri uri = GetPostApiUrl(cgi, api, version, method);

            var allParameters = new[] {
                new FormParameter("api", api),
                new FormParameter("version", version),
                new FormParameter("method", method)
            }.Concat(additionalParams).ToArray();

            using (var content = new FormParameterManager(allParameters))
            {
                byte[] formContent = await content.ToByteArrayAsync();

                _client.Headers[HttpRequestHeader.ContentType] = content.MultipartContent.Headers.ContentType.ToString().Replace("\"", string.Empty);

                byte[] result = await _client.UploadDataTaskAsync(uri, formContent);

                _client.Headers[HttpRequestHeader.ContentType] = null;

                return JsonConvert.DeserializeObject<ResultData>(System.Text.Encoding.Default.GetString(result));
            }
        }

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
        internal async Task<ResultData<T>> PostDataFromApiAsync<T>(string cgi, string api, int version, string method, FormParameter[] additionalParams = null)
        {
            Uri uri = GetPostApiUrl(cgi, api, version, method);

            var allParameters = new[] {
                //new FormParameter("_sid", Sid),
                new FormParameter("api", api),
                new FormParameter("version", version),
                new FormParameter("method", method)
            }.Concat(additionalParams).ToArray();

            using (var content = new FormParameterManager(allParameters))
            {
                byte[] formContent = await content.ToByteArrayAsync();

                _client.Headers[HttpRequestHeader.ContentType] = content.MultipartContent.Headers.ContentType.ToString().Replace("\"", string.Empty);

                byte[] result = await _client.UploadDataTaskAsync(uri, formContent);

                _client.Headers[HttpRequestHeader.ContentType] = null;

                return JsonConvert.DeserializeObject<ResultData<T>>(System.Text.Encoding.Default.GetString(result));
            }            
        }

        /// <summary>
        /// Performs a post request to the Synology API
        /// </summary>
        /// <param name="cgi">CGI path handling the request</param>
        /// <param name="api">API name handling the request</param>
        /// <param name="version">Version of the api</param>
        /// <param name="method">Method of the API</param>
        /// <param name="additionalParams">Parameters of the request</param>
        /// <returns>Result of the request</returns>
        internal ResultData PostDataFromApi(string cgi, string api, int version, string method, FormParameter[] additionalParams = null)
        {
            Uri uri = GetPostApiUrl(cgi, api, version, method);

            var allParameters = new[] {
                //new FormParameter("_sid", Sid),
                new FormParameter("api", api),
                new FormParameter("version", version),
                new FormParameter("method", method)
            }.Concat(additionalParams).ToArray();

            using (var content = new FormParameterManager(allParameters))
            {
                var formContentTask = content.ToByteArrayAsync();
                formContentTask.Wait();

                byte[] formContent = formContentTask.Result;

                _client.Headers[HttpRequestHeader.ContentType] = content.MultipartContent.Headers.ContentType.ToString().Replace("\"", string.Empty);

                byte[] result = _client.UploadData(uri, formContent);

                _client.Headers[HttpRequestHeader.ContentType] = null;

                return JsonConvert.DeserializeObject<ResultData>(System.Text.Encoding.Default.GetString(result));
            }
        }

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
        internal ResultData<T> PostDataFromApi<T>(string cgi, string api, int version, string method, FormParameter[] additionalParams = null)
        {
            Uri uri = GetPostApiUrl(cgi, api, version, method);

            var allParameters = new[] {
                //new FormParameter("_sid", Sid),
                new FormParameter("api", api),
                new FormParameter("version", version),
                new FormParameter("method", method)
            }.Concat(additionalParams).ToArray();

            using (var content = new FormParameterManager(allParameters))
            {
                var formContentTask = content.ToByteArrayAsync();
                formContentTask.Wait();

                byte[] formContent = formContentTask.Result;

                _client.Headers[HttpRequestHeader.ContentType] = content.MultipartContent.Headers.ContentType.ToString().Replace("\"", string.Empty);

                byte[] result = _client.UploadData(uri, formContent);

                _client.Headers[HttpRequestHeader.ContentType] = null;

                return JsonConvert.DeserializeObject<ResultData<T>>(System.Text.Encoding.Default.GetString(result));
            }
        }

        public void Dispose()
        {
            _client.Dispose();
            _containerScope.Dispose();
        }
    }
}