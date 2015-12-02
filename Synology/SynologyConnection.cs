using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using Synology.Classes;
using System.Threading.Tasks;
using Synology.ApiContainer;
using Synology.Utilities;
using Autofac;

namespace Synology
{
	public class SynologyConnection : IDisposable
	{
		private readonly WebClient _client;

		internal string Sid;

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

			builder.RegisterType<FileStationApi>().As<SynologyRequest>();
			builder.RegisterType<DownloadStationApi>().As<SynologyRequest>();
			builder.RegisterType<Api>().As<SynologyRequest>();
			builder.RegisterInstance(this).As<SynologyConnection>();

			_container = builder.Build();

			_containerScope = _container.BeginLifetimeScope();

			Api = _container.Resolve<Api>();
			DownloadStation = _container.Resolve<DownloadStationApi>();
			FileStation = _container.Resolve<FileStationApi>();
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

		public Api Api { get; set; }

		public DownloadStationApi DownloadStation { get; private set; }

		public FileStationApi FileStation { get; private set; }

		public void Dispose()
		{
			_client.Dispose();
			_containerScope.Dispose();
		}
	}
}