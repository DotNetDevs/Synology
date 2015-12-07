using System.Collections.Generic;
using Synology.Utilities;
using System.Threading.Tasks;

namespace Synology.Classes
{
	public abstract class SynologyRequest
	{
		public readonly SynologyApi Api;
		private readonly string _cgiPath;
		private readonly string _api;

		protected SynologyRequest(SynologyApi parentApi, string cgiPath, string api)
		{
			Api = parentApi;
			_cgiPath = cgiPath;
			_api = $"SYNO.{api}";
		}

		protected ResultData<T> GetData<T>(SynologyRequestParameters parameters)
		{
			return Api.GetData<T>(_cgiPath, _api, parameters);
		}

		protected ResultData GetData(SynologyRequestParameters parameters)
		{
			return Api.GetData(_cgiPath, _api, parameters);
		}

		protected async Task<ResultData<T>> GetDataAsync<T>(SynologyRequestParameters parameters)
		{
			return await Api.GetDataAsync<T>(_cgiPath, _api, parameters);
		}

		protected async Task<ResultData> GetDataAsync(SynologyRequestParameters parameters)
		{
			return await Api.GetDataAsync(_cgiPath, _api, parameters);
		}
	}
}