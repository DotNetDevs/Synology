using System.Collections.Generic;
using Synology.Utilities;

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

		protected string GetApiUrl(string method, int version = 1, params QueryStringParameter[] additionalParams)
		{
			return Connection.GetApiUrl(_cgiPath, _api, version, method, additionalParams);
		}
	}
}