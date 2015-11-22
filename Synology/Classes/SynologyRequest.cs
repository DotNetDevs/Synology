using System;

namespace Synology.Classes
{
	public abstract class SynologyRequest
	{
		protected readonly SynologyConnection Connection;
		readonly string _cgiPath;
		readonly string _api;

		protected SynologyRequest(SynologyConnection connection, string cgiPath, string api)
		{
			Connection = connection;
			_cgiPath = cgiPath;
			_api = api;
		}

		protected internal string GetApiUrl(string method, int version = 1, string additionalParams = null)
		{
			return Connection.GetApiUrl(_cgiPath, _api, version, method, additionalParams);
		}
	}
}