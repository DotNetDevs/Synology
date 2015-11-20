using System;

namespace Synology.Classes
{
	public abstract class SynologyRequest
	{
		protected readonly SynologyConnection Connection;
		readonly string _cgiPath;
		readonly string _api;
		readonly int _version;

		protected SynologyRequest(SynologyConnection connection, string cgiPath, string api, int version)
		{
			Connection = connection;
			_cgiPath = cgiPath;
			_api = api;
			_version = version;
		}

		protected internal string GetApiUrl(string method, string additionalParams = null)
		{
			return Connection.GetApiUrl(_cgiPath, _api, _version, method, additionalParams);
		}
	}
}