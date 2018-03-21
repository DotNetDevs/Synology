using System;
using System.Threading.Tasks;
using Synology.Classes;
using Synology.FileStation.CopyMove.Parameters;
using Synology.FileStation.CopyMove.Results;
using Synology.Interfaces;

namespace Synology.FileStation.CopyMove
{
    /// <summary>
    /// Copy move request.
    /// </summary>
    public interface ICopyMoveRequest : ISynologyRequest
    {
        /// <summary>
        /// Start to copy/move files.
        /// </summary>
        /// <param name="parameters">Parameters of the operation</param>
        [Obsolete("It uses Result, migrate to Async methods")]
        ResultData<StartResult> Start(StartParameters parameters);

        /// <summary>
        /// Get the copying/moving status.
        /// </summary>
        [Obsolete("It uses Result, migrate to Async methods")]
        ResultData<IStatusResult> Status(StatusParameters parameters);

        /// <summary>
        /// Stop a copy/move task.
        /// </summary>
        [Obsolete("It uses Result, migrate to Async methods")]
        ResultData Stop(StopParameters parameters);

        /// <summary>
        /// Start to copy/move files.
        /// </summary>
        /// <param name="parameters">Parameters of the operation</param>
        Task<ResultData<StartResult>> StartAsync(StartParameters parameters);

        /// <summary>
        /// Get the copying/moving status.
        /// </summary>
        Task<ResultData<IStatusResult>> StatusAsync(StatusParameters parameters);

        /// <summary>
        /// Stop a copy/move task.
        /// </summary>
        Task<ResultData> StopAsync(StopParameters parameters);
    }
}