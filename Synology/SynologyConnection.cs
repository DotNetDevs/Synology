using System;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using Synology.Classes;
using System.Threading.Tasks;
using Synology.Utilities;
using Autofac;
using System.Collections.Generic;

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

			url.AddParameters(additionalParams.Concat(new[] {
				new  QueryStringParameter("_sid", Sid),
				new QueryStringParameter("api", api),
				new QueryStringParameter("version", version),
				new QueryStringParameter("method", method)
			}));

			return url.ToString();
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

		public void Dispose()
		{
			_client.Dispose();
			_containerScope.Dispose();
		}
	}
}