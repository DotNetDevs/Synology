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

		public SynologyConnection(string baseHost, bool ssl = false, int port = 5000, int sslPort = 5001)
		{
			_client = new WebClient();
			_url = baseHost;
			_ssl = ssl;
			_port = port;
			_sslPort = sslPort;
		}

		internal string GetApiUrl(string cgi, string api, int version, string method, string additionalParams = null)
		{
			return string.Format("http{0}://{1}:{2}/webapi/{3}?api={4}&version={5}&method={6}{7}", _ssl ? "s" : string.Empty, _url, _ssl ? _sslPort : _port, cgi, api, version, method, !string.IsNullOrWhiteSpace(additionalParams) ? "&" + additionalParams : string.Empty);
		}

		internal ResultData<T> GetDataFromUrl<T>(string url)
		{
			return JsonConvert.DeserializeObject<ResultData<T>>(_client.DownloadString(url));
		}

		public void Dispose()
		{
			_client.Dispose();
		}
	}
}