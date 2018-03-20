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
        ResultData<MD5StartResult> Start(MD5StartParameters parameters);

        /// <summary>
        /// Status the specified parameters.
        /// </summary>
        /// <returns>The status.</returns>
        /// <param name="parameters">Parameters.</param>
        ResultData<MD5StatusResult> Status(MD5StatusParameters parameters);

        /// <summary>
        /// Stop the specified parameters.
        /// </summary>
        /// <returns>The stop.</returns>
        /// <param name="parameters">Parameters.</param>
        ResultData Stop(MD5StatusParameters parameters);
    }
}