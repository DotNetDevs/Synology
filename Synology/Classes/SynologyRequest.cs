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

		protected ResultData<T> GetData<T>(SynologyRequestParameters parameters)
		{
			return Connection.GetDataFromApi<T>(_cgiPath, _api, parameters.Version, parameters.Method, parameters.Additional);
		}

		protected ResultData GetData(SynologyRequestParameters parameters)
		{
			return Connection.GetDataFromApi(_cgiPath, _api, parameters.Version, parameters.Method, parameters.Additional);
		}

		protected async Task<ResultData<T>> GetDataAsync<T>(SynologyRequestParameters parameters)
		{
			return await Connection.GetDataFromApiAsync<T>(_cgiPath, _api, parameters.Version, parameters.Method, parameters.Additional);
		}

		protected async Task<ResultData> GetDataAsync(SynologyRequestParameters parameters)
		{
			return await Connection.GetDataFromApiAsync(_cgiPath, _api, parameters.Version, parameters.Method, parameters.Additional);
		}
	}
}