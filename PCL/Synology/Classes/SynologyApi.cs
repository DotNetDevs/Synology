using Synology.Parameters;
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

        internal T Request<T>() where T : SynologyRequest => Connection.Request<T>();

        internal ResultData<T> GetData<T>(string cgiPath, string api, SynologyRequestParameters parameters) => Connection.GetDataFromApi<T>(cgiPath, api, parameters.Version, parameters.Method, parameters.Additional);

        /// <summary>
        /// Perform post requests returning specific data
        /// </summary>
        /// <typeparam name="T">Result return data type</typeparam>
        /// <param name="cgiPath">Path of the cgi handling the request</param>
        /// <param name="api">Name of the API handling the request</param>
        /// <param name="parameters">Parameters of the request</param>
        /// <returns>Result of the request and its data</returns>
        internal ResultData<T> PostData<T>(string cgiPath, string api, SynologyPostParameters parameters) => Connection.PostDataFromApi<T>(cgiPath, api, parameters.Version, parameters.Method, parameters.Additional);

        internal ResultData GetData(string cgiPath, string api, SynologyRequestParameters parameters) => Connection.GetDataFromApi(cgiPath, api, parameters.Version, parameters.Method, parameters.Additional);

        /// <summary>
        /// Perform post requests returning generic success / error data
        /// </summary>
        /// <param name="cgiPath">Path of the cgi handling the request</param>
        /// <param name="api">Name of the API handling the request</param>
        /// <param name="parameters">Parameters of the request</param>
        /// <returns>Result of the request</returns>
        internal ResultData PostData(string cgiPath, string api, SynologyPostParameters parameters) => Connection.PostDataFromApi(cgiPath, api, parameters.Version, parameters.Method, parameters.Additional);

        internal async Task<ResultData<T>> GetDataAsync<T>(string cgiPath, string api, SynologyRequestParameters parameters) => await Connection.GetDataFromApiAsync<T>(cgiPath, api, parameters.Version, parameters.Method, parameters.Additional);

        /// <summary>
        /// Perform asynchronous post requests returning specific data
        /// </summary>
        /// <typeparam name="T">Specific result return data type</typeparam>
        /// <param name="cgiPath">Path of the cgi handling the request</param>
        /// <param name="api">Name of the API handling the request</param>
        /// <param name="parameters">Parameters of the request</param>
        /// <returns>Result of the request</returns>
        internal async Task<ResultData<T>> PostDataAsync<T>(string cgiPath, string api, SynologyPostParameters parameters) => await Connection.PostDataFromApiAsync<T>(cgiPath, api, parameters.Version, parameters.Method, parameters.Additional);

        internal async Task<ResultData> GetDataAsync(string cgiPath, string api, SynologyRequestParameters parameters) => await Connection.GetDataFromApiAsync(cgiPath, api, parameters.Version, parameters.Method, parameters.Additional);

        /// <summary>
        /// Perform asynchronous post requests returning generic success / error data
        /// </summary>
        /// <param name="cgiPath">Path of the cgi handling the request</param>
        /// <param name="api">Name of the API handling the request</param>
        /// <param name="parameters">Parameters of the request</param>
        /// <returns>Result of the request</returns>
        internal async Task<ResultData> PostDataAsync(string cgiPath, string api, SynologyPostParameters parameters) => await Connection.PostDataFromApiAsync(cgiPath, api, parameters.Version, parameters.Method, parameters.Additional);
    }
}