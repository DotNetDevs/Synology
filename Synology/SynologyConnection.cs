using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using Synology.Classes;
using System.Threading.Tasks;
using Synology.Utilities;
using Autofac;
using Autofac.Core;

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

			_client = new WebClient {
				BaseAddress = $"http{sslPostfix}://{baseHost}:{usedPort}/webapi/"
			};

			var builder = new ContainerBuilder();

			builder.RegisterInstance(this).As<SynologyConnection>();

			_container = builder.Build();

			_containerScope = _container.BeginLifetimeScope();
		}

		private void RegisterType<T>()
		{
			var builder = new ContainerBuilder();

			builder.RegisterType<T>();
			builder.Update(_container);
		}

		private T ResolveType<T>() where T : class
		{
			var res = default(T);

			if (!_container.TryResolve<T>(out res))
			{
				RegisterType<T>();

				return ResolveType<T>();
			}

			return res;
		}

		public T Request<T>() where T : SynologyRequest
		{
			return ResolveType<T>();
		}

		public T Api<T>() where T : SynologyApi
		{
			return ResolveType<T>();
		}

		public string GetApiUrl(string cgi, string api, int version, string method, IEnumerable<QueryStringParameter> additionalParams = null)
		{
			var url = new QueryStringManager(cgi);

			url.AddParameter(new QueryStringParameter("_sid", Sid));
			url.AddParameter(new QueryStringParameter("api", api));
			url.AddParameter(new QueryStringParameter("version", version));
			url.AddParameter(new QueryStringParameter("method", method));
			url.AddParameters(additionalParams);

			return url.ToString();
		}

		public ResultData GetDataFromUrl(string url)
		{
			var json = _client.DownloadString(url);
			return JsonConvert.DeserializeObject<ResultData>(json);
		}

		public ResultData<T> GetDataFromUrl<T>(string url)
		{
			var json = _client.DownloadString(url);
			return JsonConvert.DeserializeObject<ResultData<T>>(json);
		}

		public async Task<ResultData<T>> GetDataFromUrlAsync<T>(string url)
		{
			var json = await _client.DownloadStringTaskAsync(url);
			return JsonConvert.DeserializeObject<ResultData<T>>(json);
		}

		public void Dispose()
		{
			_client.Dispose();
			_containerScope.Dispose();
		}
	}
}