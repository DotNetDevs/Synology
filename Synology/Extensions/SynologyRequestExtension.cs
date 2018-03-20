using System;
using System.Linq;
using System.Threading.Tasks;
using Synology.Attributes;
using Synology.Classes;
using Synology.Interfaces;
using Synology.Parameters;

namespace Synology
{
    internal static class SynologyRequestExtension
    {
        private static T MethodResult<T>(this ISynologyRequest request, string name, params object[] parameters) where T : ResultData
        {
            var type = request.GetType();
            var methods = type.GetMethods();
            var filteredMethods = methods.Where(t => t.CustomAttributes.Any(a => a.AttributeType == typeof(RequestMethodAttribute)));
            var method = filteredMethods.FirstOrDefault(t => t.GetCustomAttributes(typeof(RequestMethodAttribute), true).Cast<RequestMethodAttribute>().FirstOrDefault()?.Name == name);
            var response = method?.Invoke(request, parameters);
            return response as T;
        }

        internal static ResultData Method(this ISynologyRequest request, string name, params object[] parameters) => request.MethodResult<ResultData>(name, parameters);

        internal static ResultData<T> Method<T>(this ISynologyRequest request, string name, params object[] parameters) => request.MethodResult<ResultData<T>>(name, parameters);

        [Obsolete("It uses Result, migrate to Async methods")]
        internal static  ResultData<T> GetData<T>(this ISynologyRequest request, SynologyRequestParameters parameters) => request.Api.GetData<T>(request.CgiPath, request.ApiName, parameters);

        [Obsolete("It uses Result, migrate to Async methods")]
        internal static  ResultData GetData(this ISynologyRequest request, SynologyRequestParameters parameters) => request.Api.GetData(request.CgiPath, request.ApiName, parameters);

        internal static  async Task<ResultData<T>> GetDataAsync<T>(this ISynologyRequest request, SynologyRequestParameters parameters) => await request.Api.GetDataAsync<T>(request.CgiPath, request.ApiName, parameters);

        internal static  async Task<ResultData> GetDataAsync(this ISynologyRequest request, SynologyRequestParameters parameters) => await request.Api.GetDataAsync(request.CgiPath, request.ApiName, parameters);

        /// <summary>
        /// Performs synchronous post request with specific response
        /// </summary>
        /// <typeparam name="T">Type of the result data</typeparam>
        /// <param name="parameters">Parameters used for the request</param>
        /// <returns>Specific result data</returns>
        [Obsolete("It uses Result, migrate to Async methods")]
        internal static  ResultData<T> PostData<T>(this ISynologyRequest request, SynologyPostParameters parameters) => request.Api.PostData<T>(request.CgiPath, request.ApiName, parameters);

        /// <summary>
        /// Performs synchronous post request
        /// </summary>
        /// <param name="parameters">Parameters used for the request</param>
        /// <returns>Generic result data</returns>
        [Obsolete("It uses Result, migrate to Async methods")]
        internal static  ResultData PostData(this ISynologyRequest request, SynologyPostParameters parameters) => request.Api.PostData(request.CgiPath, request.ApiName, parameters);

        /// <summary>
        /// Performs asynchronous post request with specific response
        /// </summary>
        /// <typeparam name="T">Type of the result data</typeparam>
        /// <param name="parameters">Parameters used for the request</param>
        /// <returns>Specific result data</returns>
        internal static  async Task<ResultData<T>> PostDataAsync<T>(this ISynologyRequest request, SynologyPostParameters parameters) => await request.Api.PostDataAsync<T>(request.CgiPath, request.ApiName, parameters);

        /// <summary>
        /// Performs asynchronous post request
        /// </summary>
        /// <param name="parameters">Parameters used for the request</param>
        /// <returns>Generic result data</returns>
        internal static  async Task<ResultData> PostDataAsync(this ISynologyRequest request, SynologyPostParameters parameters) => await request.Api.PostDataAsync(request.CgiPath, request.ApiName, parameters);
    }
}
