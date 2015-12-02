using System.Collections.Generic;
using Synology.Utilities;
using System.Threading.Tasks;

namespace Synology.Classes
{
	public abstract class SynologyRequest
	{
		protected readonly SynologyConnection Connection;
		private readonly string _cgiPath;
		private readonly string _api;

		protected SynologyRequest(SynologyConnection connection, string cgiPath, string api)
		{
			Connection = connection;
			_cgiPath = cgiPath;
			_api = api;
		}

		protected ResultData<T> GetData<T>(string method, int version = 1, params QueryStringParameter[] additionalParams)
		{
			var url = Connection.GetApiUrl(_cgiPath, _api, version, method, additionalParams);

			return Connection.GetDataFromUrl<T>(url);
		}

		protected ResultData GetData(string method, int version = 1, params QueryStringParameter[] additionalParams)
		{
			var url = Connection.GetApiUrl(_cgiPath, _api, version, method, additionalParams);

			return Connection.GetDataFromUrl(url);
		}
	}
}