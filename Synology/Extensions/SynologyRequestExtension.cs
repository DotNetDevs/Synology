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
        [Obsolete("It uses Result, migrate to Async methods")]
        private static T MethodResult<T>(this ISynologyRequest request, string name, params object[] parameters) where T : ResultData
        {
            var type = request.GetType();
            var methods = type.GetMethods();
            var filteredMethods = methods.Where(t => t.CustomAttributes.Any(a => a.AttributeType == typeof(RequestMethodAttribute)));
            var method = filteredMethods.FirstOrDefault(t => (t.ReturnType == typeof(T) || t.ReturnType == typeof(void)) && t.GetCustomAttributes(typeof(RequestMethodAttribute), true).Cast<RequestMethodAttribute>().FirstOrDefault()?.Name == name);
            var response = method?.Invoke(request, parameters);
            return response as T;
        }

        [Obsolete("It uses Result, migrate to Async methods")]
        internal static ResultData Method(this ISynologyRequest request, string name, params object[] parameters) => request.MethodResult<ResultData>(name, parameters);

        [Obsolete("It uses Result, migrate to Async methods")]
        internal static ResultData<T> Method<T>(this ISynologyRequest request, string name, params object[] parameters) => request.MethodResult<ResultData<T>>(name, parameters);

        private static async Task<T> MethodResultAsync<T>(this ISynologyRequest request, string name, params object[] parameters) where T : ResultData
        {
            var type = request.GetType();
            var methods = type.GetMethods();
            var filteredMethods = methods.Where(t => t.CustomAttributes.Any(a => a.AttributeType == typeof(RequestMethodAttribute)));
            var method = filteredMethods.FirstOrDefault(t => (typeof(Task) == t.ReturnType || typeof(Task<>) == t.ReturnType.GetGenericTypeDefinition()) && t.GetCustomAttributes(typeof(RequestMethodAttribute), true).Cast<RequestMethodAttribute>().FirstOrDefault()?.Name == name);
            var response = await (Task<T>)method?.Invoke(request, parameters);
            return response as T;
        }

        internal static async Task<ResultData> MethodAsync(this ISynologyRequest request, string name, params object[] parameters) => await request.MethodResultAsync<ResultData>(name, parameters);

        internal static async Task<ResultData<T>> MethodAsync<T>(this ISynologyRequest request, string name, params object[] parameters) => await request.MethodResultAsync<ResultData<T>>(name, parameters);

        [Obsolete("It uses Result, migrate to Async methods")]
        internal static  ResultData<T> GetData<T>(this ISynologyRequest request, SynologyRequestParameters parameters) => request.Api.GetData<T>(request.CgiPath, request.ApiName, parameters);

        [Obsolete("It uses Result, migrate to Async methods")]
        internal static  ResultData GetData(this ISynologyRequest request, SynologyRequestParameters parameters) => request.Api.GetData(request.CgiPath, request.ApiName, parameters);

        internal static  async Task<ResultData<T>> GetDataAsync<T>(this ISynologyRequest request, SynologyRequestParameters parameters) => await request.Api.GetDataAsync<T>(await request.CgiPathAsync(), request.ApiName, parameters);

        internal static  async Task<ResultData> GetDataAsync(this ISynologyRequest request, SynologyRequestParameters parameters) => await request.Api.GetDataAsync(await request.CgiPathAsync(), request.ApiName, parameters);

        /// <summary>
        /// Posts the data.
        /// </summary>
        /// <returns>The data.</returns>
        /// <param name="request">Request.</param>
        /// <param name="parameters">Parameters.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        [Obsolete("It uses Result, migrate to Async methods")]
        internal static  ResultData<T> PostData<T>(this ISynologyRequest request, SynologyPostParameters parameters) => request.Api.PostData<T>(request.CgiPath, request.ApiName, parameters);

        /// <summary>
        /// Posts the data.
        /// </summary>
        /// <returns>The data.</returns>
        /// <param name="request">Request.</param>
        /// <param name="parameters">Parameters.</param>
        [Obsolete("It uses Result, migrate to Async methods")]
        internal static  ResultData PostData(this ISynologyRequest request, SynologyPostParameters parameters) => request.Api.PostData(request.CgiPath, request.ApiName, parameters);

        /// <summary>
        /// Posts the data async.
        /// </summary>
        /// <returns>The data async.</returns>
        /// <param name="request">Request.</param>
        /// <param name="parameters">Parameters.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        internal static  async Task<ResultData<T>> PostDataAsync<T>(this ISynologyRequest request, SynologyPostParameters parameters) => await request.Api.PostDataAsync<T>(await request.CgiPathAsync(), request.ApiName, parameters);

        /// <summary>
        /// Posts the data async.
        /// </summary>
        /// <returns>The data async.</returns>
        /// <param name="request">Request.</param>
        /// <param name="parameters">Parameters.</param>
        internal static  async Task<ResultData> PostDataAsync(this ISynologyRequest request, SynologyPostParameters parameters) => await request.Api.PostDataAsync(await request.CgiPathAsync(), request.ApiName, parameters);
    }
}
