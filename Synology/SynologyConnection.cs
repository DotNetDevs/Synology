using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using Synology.Classes;
using System.Threading.Tasks;
using Synology.Utilities;
using Autofac;
using Synology.DownloadStation;
using Synology.FileStation;
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

			RegisterApi<DownloadStationApi>();
			RegisterApi<FileStationApi>();
			RegisterApi<Api.Api>();
		}

		public void RegisterApi<T>() where T : SynologyApi
		{
			var builder = new ContainerBuilder();

			builder.RegisterType<T>().AsSelf().As<SynologyApi>();
			builder.Update(_container);
		}

		public void RegisterRequest<TRequest>() where TRequest : SynologyRequest
		{
			var builder = new ContainerBuilder();

			builder.RegisterType<TRequest>().AsSelf().As<SynologyRequest>();
			builder.Update(_container);
		}

		public T GetRequest<T>() where T : SynologyRequest
		{
			return _container.Resolve<T>();
		}

		public T GetApi<T>() where T : SynologyApi
		{
			return _container.Resolve<T>();
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