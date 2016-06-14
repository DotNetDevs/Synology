using Synology.Classes;
using Synology.FileStation.CopyMove.Parameters;
using Synology.FileStation.CopyMove.Results;
using Synology.Parameters;

namespace Synology.FileStation.CopyMove
{
    /// <summary>
    /// Copy / Move operations from the Synology API
    /// This is a non-blocking API. You need to start to copy/move files with start method. Then, you should poll requests with status method to get the progress status, or make a request with stop method to cancel the operation.
    /// </summary>
    public class CopyMoveRequest : SynologyRequest
    {
        public CopyMoveRequest(SynologyApi parentApi) : base(parentApi, "entry.cgi", "FileStation.CopyMove")
        {
        }

        /// <summary>
        /// Start to copy/move files.
        /// </summary>
        /// <param name="parameters">Parameters of the operation</param>
        public ResultData<StartResult> Start(StartParameters parameters)
        {
            return GetData<StartResult>(new SynologyRequestParameters
            {
                Version = 3,
                Method = "start",
                Additional = parameters
            });
        }

        /// <summary>
        /// Get the copying/moving status.
        /// </summary>
        public ResultData<StatusResult> Status(StatusParameters parameters)
        {
            return GetData<StatusResult>(new SynologyRequestParameters
            {
                Version = 3,
                Method = "status",
                Additional = parameters
            });
        }

        /// <summary>
        /// Stop a copy/move task.
        /// </summary>
        public ResultData Stop(StopParameters parameters)
        {
            return GetData(new SynologyRequestParameters
            {
                Version = 3,
                Method = "stop",
                Additional = parameters
            });
        }
    }
}
