using System.Threading.Tasks;

namespace Synology.Classes
{
	public abstract class SynologyApi
	{
		public readonly SynologyConnection Connection;

		protected SynologyApi(SynologyConnection connection)
		{
			Connection = connection;
		}

		public T Request<T>() where T : SynologyRequest
		{
			return Connection.Request<T>();
		}

		public ResultData<T> GetData<T>(string cgiPath, string api, SynologyRequestParameters parameters)
		{
			return Connection.GetDataFromApi<T>(cgiPath, api, parameters.Version, parameters.Method, parameters.Additional);
		}

		public ResultData GetData(string cgiPath, string api, SynologyRequestParameters parameters)
		{
			return Connection.GetDataFromApi(cgiPath, api, parameters.Version, parameters.Method, parameters.Additional);
		}

		public async Task<ResultData<T>> GetDataAsync<T>(string cgiPath, string api, SynologyRequestParameters parameters)
		{
			return await Connection.GetDataFromApiAsync<T>(cgiPath, api, parameters.Version, parameters.Method, parameters.Additional);
		}

		public async Task<ResultData> GetDataAsync(string cgiPath, string api, SynologyRequestParameters parameters)
		{
			return await Connection.GetDataFromApiAsync(cgiPath, api, parameters.Version, parameters.Method, parameters.Additional);
		}
	}
}