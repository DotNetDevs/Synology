using System.Threading.Tasks;
using Synology.Classes;
using Synology.FileStation.MD5.Parameters;
using Synology.FileStation.MD5.Results;
using Synology.Interfaces;

namespace Synology.FileStation.MD5
{
    /// <summary>
    /// MD 5 request.
    /// </summary>
    public interface IMD5Request : ISynologyRequest
    {
        /// <summary>
        /// Start the specified parameters.
        /// </summary>
        /// <returns>The start.</returns>
        /// <param name="parameters">Parameters.</param>
        Task<ResultData<IMD5StartResult>> StartAsync(MD5StartParameters parameters);

        /// <summary>
        /// Status the specified parameters.
        /// </summary>
        /// <returns>The status.</returns>
        /// <param name="parameters">Parameters.</param>
        Task<ResultData<IMD5StatusResult>> StatusAsync(MD5StatusParameters parameters);

        /// <summary>
        /// Stop the specified parameters.
        /// </summary>
        /// <returns>The stop.</returns>
        /// <param name="parameters">Parameters.</param>
        Task<ResultData> StopAsync(MD5StatusParameters parameters);
    }
}