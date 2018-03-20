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
        ResultData<StartResult> Start(StartParameters parameters);

        /// <summary>
        /// Get the copying/moving status.
        /// </summary>
        ResultData<StatusResult> Status(StatusParameters parameters);

        /// <summary>
        /// Stop a copy/move task.
        /// </summary>
        ResultData Stop(StopParameters parameters);
    }
}