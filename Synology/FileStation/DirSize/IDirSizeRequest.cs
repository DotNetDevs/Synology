using System;
using System.Threading.Tasks;
using Synology.Classes;
using Synology.FileStation.DirSize.Parameters;
using Synology.FileStation.DirSize.Results;
using Synology.Interfaces;

namespace Synology.FileStation.DirSize
{
    /// <summary>
    /// Dir size request.
    /// </summary>
    public interface IDirSizeRequest : ISynologyRequest
    {
        /// <summary>
        /// Start the specified parameters.
        /// </summary>
        /// <returns>The start.</returns>
        /// <param name="parameters">Parameters.</param>
        Task<ResultData<IDirSizeStartResult>> StartAsync(DirSizeStartParameters parameters);

        /// <summary>
        /// Status the specified parameters.
        /// </summary>
        /// <returns>The status.</returns>
        /// <param name="parameters">Parameters.</param>
        Task<ResultData<IDirSizeStatusResult>> StatusAsync(DirSizeStatusParameters parameters);

        /// <summary>
        /// Stop the specified parameters.
        /// </summary>
        /// <returns>The stop.</returns>
        /// <param name="parameters">Parameters.</param>
        Task<ResultData> StopAsync(DirSizeStatusParameters parameters);
    }
}