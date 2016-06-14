using System.Linq;
using System.Threading.Tasks;
using Synology.Attributes;
using System.Collections.Generic;

namespace Synology.Classes
{
    public abstract class SynologyRequest
    {
        public readonly SynologyApi Api;
        public string CgiPath { get; private set; }
        public readonly string ApiName;

        protected SynologyRequest(SynologyApi parentApi, string cgiPath, string api)
        {
            Api = parentApi;
            CgiPath = cgiPath;
            ApiName = $"SYNO.{api}";

            LoadInfo();
        }

        protected void LoadInfo()
        {
            //Request and Method returns null if the API or the Method is not found.
            var data = Api.Connection.Request("SYNO.API.Info")?.Method<Dictionary<string, ApiInfo>>("query", ApiName);

            //If the Info API has returned a value and contains the current API Info, this update the associated cgi.
            if (data != null && data.Data.ContainsKey(ApiName))
            {
                var info = data.Data[ApiName];
                CgiPath = info.Path;
            }
        }

        protected ResultData<T> GetData<T>(SynologyRequestParameters parameters) => Api.GetData<T>(CgiPath, ApiName, parameters);

        protected ResultData GetData(SynologyRequestParameters parameters) => Api.GetData(CgiPath, ApiName, parameters);

        protected async Task<ResultData<T>> GetDataAsync<T>(SynologyRequestParameters parameters) => await Api.GetDataAsync<T>(CgiPath, ApiName, parameters);

        protected async Task<ResultData> GetDataAsync(SynologyRequestParameters parameters) => await Api.GetDataAsync(CgiPath, ApiName, parameters);

        /// <summary>
        /// Performs synchronous post request with specific response
        /// </summary>
        /// <typeparam name="T">Type of the result data</typeparam>
        /// <param name="parameters">Parameters used for the request</param>
        /// <returns>Specific result data</returns>
        protected ResultData<T> PostData<T>(SynologyPostParameters parameters) => Api.PostData<T>(CgiPath, ApiName, parameters);

        /// <summary>
        /// Performs synchronous post request
        /// </summary>
        /// <param name="parameters">Parameters used for the request</param>
        /// <returns>Generic result data</returns>
        protected ResultData PostData(SynologyPostParameters parameters) => Api.PostData(CgiPath, ApiName, parameters);

        /// <summary>
        /// Performs asynchronous post request with specific response
        /// </summary>
        /// <typeparam name="T">Type of the result data</typeparam>
        /// <param name="parameters">Parameters used for the request</param>
        /// <returns>Specific result data</returns>
        protected async Task<ResultData<T>> PostDataAsync<T>(SynologyPostParameters parameters) => await Api.PostDataAsync<T>(CgiPath, ApiName, parameters);

        /// <summary>
        /// Performs asynchronous post request
        /// </summary>
        /// <param name="parameters">Parameters used for the request</param>
        /// <returns>Generic result data</returns>
        protected async Task<ResultData> PostDataAsync(SynologyPostParameters parameters) => await Api.PostDataAsync(CgiPath, ApiName, parameters);

        private T MethodResult<T>(string name, params object[] parameters) where T : ResultData
        {
            try
            {

                var methods = GetType().GetMethods().Where(t => t.CustomAttributes.Any(a => a.AttributeType == typeof(RequestMethodAttribute)));

                foreach (var method in methods)
                    if (method.GetCustomAttributes(typeof(RequestMethodAttribute), true).Cast<RequestMethodAttribute>().First().Name == name)
                        return method.Invoke(this, parameters) as T;
            }
            catch
            {
            }

            return null;
        }

        internal ResultData Method(string name, params object[] parameters) => MethodResult<ResultData>(name, parameters);

        internal ResultData<T> Method<T>(string name, params object[] parameters) => MethodResult<ResultData<T>>(name, parameters);
    }
}