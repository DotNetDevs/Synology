using System.Linq;
using System.Threading.Tasks;
using Synology.Attributes;

namespace Synology.Classes
{
    public abstract class SynologyRequest
    {
        public readonly SynologyApi Api;
        public readonly string CgiPath;
        public readonly string ApiName;

        protected SynologyRequest(SynologyApi parentApi, string cgiPath, string api)
        {
            Api = parentApi;
            CgiPath = cgiPath;
            ApiName = $"SYNO.{api}";

            //TODO: when implementation completes it can be tested here.
            //LoadInfo();
        }

        protected void LoadInfo()
        {
            Api.Connection.Request("Syno.API.Info").Method("query", ApiName);

            //TODO: Load data from the method above to set the correct cgi and eventually the available version.
        }

        protected ResultData<T> GetData<T>(SynologyRequestParameters parameters)
        {
            return Api.GetData<T>(CgiPath, ApiName, parameters);
        }

        protected ResultData GetData(SynologyRequestParameters parameters)
        {
            return Api.GetData(CgiPath, ApiName, parameters);
        }

        protected async Task<ResultData<T>> GetDataAsync<T>(SynologyRequestParameters parameters)
        {
            return await Api.GetDataAsync<T>(CgiPath, ApiName, parameters);
        }

        protected async Task<ResultData> GetDataAsync(SynologyRequestParameters parameters)
        {
            return await Api.GetDataAsync(CgiPath, ApiName, parameters);
        }

        /// <summary>
        /// Performs synchronous post request with specific response
        /// </summary>
        /// <typeparam name="T">Type of the result data</typeparam>
        /// <param name="parameters">Parameters used for the request</param>
        /// <returns>Specific result data</returns>
        protected ResultData<T> PostData<T>(SynologyPostParameters parameters)
        {
            return Api.PostData<T>(CgiPath, ApiName, parameters);
        }

        /// <summary>
        /// Performs synchronous post request
        /// </summary>
        /// <param name="parameters">Parameters used for the request</param>
        /// <returns>Generic result data</returns>
        protected ResultData PostData(SynologyPostParameters parameters)
        {
            return Api.PostData(CgiPath, ApiName, parameters);
        }

        /// <summary>
        /// Performs asynchronous post request with specific response
        /// </summary>
        /// <typeparam name="T">Type of the result data</typeparam>
        /// <param name="parameters">Parameters used for the request</param>
        /// <returns>Specific result data</returns>
        protected async Task<ResultData<T>> PostDataAsync<T>(SynologyPostParameters parameters)
        {
            return await Api.PostDataAsync<T>(CgiPath, ApiName, parameters);
        }

        /// <summary>
        /// Performs asynchronous post request
        /// </summary>
        /// <param name="parameters">Parameters used for the request</param>
        /// <returns>Generic result data</returns>
        protected async Task<ResultData> PostDataAsync(SynologyPostParameters parameters)
        {
            return await Api.PostDataAsync(CgiPath, ApiName, parameters);
        }

        internal ResultData Method(string name, params object[] parameters)
        {
            try
            {

                var methods = GetType().GetMethods().Where(t => t.CustomAttributes.Any(a => a.AttributeType == typeof(RequestMethodAttribute)));

                foreach (var method in methods)
                    if (method.GetCustomAttributes(typeof(RequestMethodAttribute), true).Cast<RequestMethodAttribute>().First().Name == name)
                        return method.Invoke(this, parameters) as ResultData;
            }
            catch
            {
            }

            return null;
        }
    }
}