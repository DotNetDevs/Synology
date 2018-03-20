using System;
using System.Threading.Tasks;
using Synology.Classes;
using Synology.Interfaces;
using Synology.Parameters;

namespace Synology
{
	internal static class SynologyApiExtension
    {
        internal static T Request<T>(this ISynologyApi api) where T : class, ISynologyRequest => api.Connection.Request<T>();

        [Obsolete("It uses Result, migrate to Async methods")]
        internal static ResultData<T> GetData<T>(this ISynologyApi api, string cgiPath, string apiName, SynologyRequestParameters parameters) => api.Connection.GetDataFromApi<T>(cgiPath, apiName, parameters.Version, parameters.Method, parameters.Additional);

		/// <summary>
		/// Perform post requests returning specific data
		/// </summary>
		/// <typeparam name="T">Result return data type</typeparam>
		/// <param name="api"></param>
		/// <param name="cgiPath">Path of the cgi handling the request</param>
		/// <param name="apiName">Name of the API handling the request</param>
		/// <param name="parameters">Parameters of the request</param>
		/// <returns>Result of the request and its data</returns>
        [Obsolete("It uses Result, migrate to Async methods")]
		internal static ResultData<T> PostData<T>(this ISynologyApi api, string cgiPath, string apiName, SynologyPostParameters parameters) => api.Connection.PostDataFromApi<T>(cgiPath, apiName, parameters.Version, parameters.Method, parameters.Additional);

        [Obsolete("It uses Result, migrate to Async methods")]
        internal static ResultData GetData(this ISynologyApi api, string cgiPath, string apiName, SynologyRequestParameters parameters) => api.Connection.GetDataFromApi(cgiPath, apiName, parameters.Version, parameters.Method, parameters.Additional);

		/// <summary>
		/// Perform post requests returning generic success / error data
		/// </summary>
		/// <param name="api"></param>
		/// <param name="cgiPath">Path of the cgi handling the request</param>
		/// <param name="apiName">Name of the API handling the request</param>
		/// <param name="parameters">Parameters of the request</param>
		/// <returns>Result of the request</returns>
        [Obsolete("It uses Result, migrate to Async methods")]
		internal static ResultData PostData(this ISynologyApi api, string cgiPath, string apiName, SynologyPostParameters parameters) => api.Connection.PostDataFromApi(cgiPath, apiName, parameters.Version, parameters.Method, parameters.Additional);

        internal static async Task<ResultData<T>> GetDataAsync<T>(this ISynologyApi api, string cgiPath, string apiName, SynologyRequestParameters parameters) => await api.Connection.GetDataFromApiAsync<T>(cgiPath, apiName, parameters.Version, parameters.Method, parameters.Additional);

        /// <summary>
        /// Perform asynchronous post requests returning specific data
        /// </summary>
        /// <typeparam name="T">Specific result return data type</typeparam>
        /// <param name="api"></param>
        /// <param name="cgiPath">Path of the cgi handling the request</param>
        /// <param name="apiName">Name of the API handling the request</param>
        /// <param name="parameters">Parameters of the request</param>
        /// <returns>Result of the request</returns>
        internal static async Task<ResultData<T>> PostDataAsync<T>(this ISynologyApi api, string cgiPath, string apiName, SynologyPostParameters parameters) => await api.Connection.PostDataFromApiAsync<T>(cgiPath, apiName, parameters.Version, parameters.Method, parameters.Additional);

        internal static async Task<ResultData> GetDataAsync(this ISynologyApi api, string cgiPath, string apiName, SynologyRequestParameters parameters) => await api.Connection.GetDataFromApiAsync(cgiPath, apiName, parameters.Version, parameters.Method, parameters.Additional);

		/// <summary>
		/// Perform asynchronous post requests returning generic success / error data
		/// </summary>
		/// <param name="api"></param>
		/// <param name="cgiPath">Path of the cgi handling the request</param>
		/// <param name="apiName">Name of the API handling the request</param>
		/// <param name="parameters">Parameters of the request</param>
		/// <returns>Result of the request</returns>
		internal static async Task<ResultData> PostDataAsync(this ISynologyApi api, string cgiPath, string apiName, SynologyPostParameters parameters) => await api.Connection.PostDataFromApiAsync(cgiPath, apiName, parameters.Version, parameters.Method, parameters.Additional);
    }
}
