using System;
using System.Net;
using Newtonsoft.Json;
using Synology.Classes;
using System.Threading.Tasks;

namespace Synology
{
	public class SynologyConnection : IDisposable
	{
		readonly WebClient _client;

		string _url { get; set; }

		bool _ssl { get; set; }

		int _port { get; set; }

		int _sslPort { get; set; }

		internal string Sid { get; set; }

		public SynologyConnection(string baseHost, bool ssl = false, int port = 5000, int sslPort = 5001)
		{
			_client = new WebClient();
			_url = baseHost;
			_ssl = ssl;
			_port = port;
			_sslPort = sslPort;
			_client.BaseAddress = string.Format("http{0}://{1}:{2}/webapi/", _ssl ? "s" : string.Empty, _url, _ssl ? _sslPort : _port);
		}

		internal string GetApiUrl(string cgi, string api, int version, string method, string additionalParams = null)
		{
			return string.Format("{0}?{1}api={2}&version={3}&method={4}{5}", cgi, !string.IsNullOrWhiteSpace(Sid) ? "_sid=" + Sid + "&" : string.Empty, api, version, method, !string.IsNullOrWhiteSpace(additionalParams) ? "&" + additionalParams : string.Empty);
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
		}
	}
}