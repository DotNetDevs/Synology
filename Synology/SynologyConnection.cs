using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using Synology.Classes;
using System.Threading.Tasks;
using Synology.Auth;
using Synology.DownloadStation;
using Synology.Utilities;
using InfoRequest = Synology.Info.InfoRequest;

namespace Synology
{
	public class SynologyConnection : IDisposable
	{
		private readonly WebClient _client;

		internal string Sid;

		public SynologyConnection(string baseHost, bool ssl = false, int port = 5000, int sslPort = 5001)
		{
			_client = new WebClient
			{
				BaseAddress = $"http{(ssl ? "s" : string.Empty)}://{baseHost}:{(ssl ? sslPort : port)}/webapi/"
			};

			Auth = new AuthRequest(this);
			Info = new InfoRequest(this);
			DownloadStation = new DownloadStationApi
			{
				Info = new DownloadStation.InfoRequest(this),
				Schedule = new ScheduleRequest(this),
				Task = new TaskRequest(this)
			};
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

		#region Requests
		public AuthRequest Auth { get; private set; }

		public InfoRequest Info { get; private set; }

		public class DownloadStationApi
		{
			internal DownloadStationApi()
			{
			}

			public DownloadStation.InfoRequest Info { get; internal set; }
			public ScheduleRequest Schedule { get; internal set; }
			public TaskRequest Task { get; internal set; }
		}

		public DownloadStationApi DownloadStation { get; private set; }
		#endregion

		public void Dispose()
		{
			_client.Dispose();
		}
	}
}