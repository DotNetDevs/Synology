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

namespace Synology
{
	public class SynologyConnection : IDisposable
	{
		private readonly WebClient _client;

		public string Sid { private get; set; }

		private readonly ContainerBuilder _builder;
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

			_builder = new ContainerBuilder();

			_builder.RegisterInstance(this).As<SynologyConnection>();

			_container = _builder.Build();

			_containerScope = _container.BeginLifetimeScope();

			RegisterApi<Api.Api>();
			RegisterApi<DownloadStationApi>();
			RegisterApi<FileStationApi>();
		}

		public void RegisterApi<T>() where T : SynologyApi
		{
			_builder.RegisterType<T>().As<SynologyApi>();
			_builder.Update(_container);
		}

		public void RegisterRequest<TRequest>() where TRequest : SynologyRequest
		{
			_builder.RegisterType<TRequest>().As<SynologyRequest>();
			_builder.Update(_container);
		}

		public T GetRequest<T>() where T : SynologyRequest
		{
			return _container.Resolve<T>();
		}

		public T GetApi<T>() where T : SynologyApi
		{
			return _container.Resolve<T>();
		}

		internal string GetApiUrl(string cgi, string api, int version, string method, IEnumerable<QueryStringParameter> additionalParams = null)
		{
			var url = new QueryStringManager(cgi);

			url.AddParameter(new QueryStringParameter("_sid", Sid));
			url.AddParameter(new QueryStringParameter("api", api));
			url.AddParameter(new QueryStringParameter("version", version));
			url.AddParameter(new QueryStringParameter("method", method));
			url.AddParameters(additionalParams);

			return url.ToString();
		}

		internal ResultData GetDataFromUrl(string url)
		{
			var json = _client.DownloadString(url);
			return JsonConvert.DeserializeObject<ResultData>(json);
		}

		internal ResultData<T> GetDataFromUrl<T>(string url)
		{
			var json = _client.DownloadString(url);
			return JsonConvert.DeserializeObject<ResultData<T>>(json);
		}

		internal async Task<ResultData<T>> GetDataFromUrlAsync<T>(string url)
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