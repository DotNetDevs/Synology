using Synology.Classes;
using Synology.DownloadStation.TaskEx.Parameters;
using Synology.DownloadStation.TaskEx.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synology.DownloadStation.TaskEx
{
    /// <summary>
    /// Task (Extended) returning the ids of the downloads.
    /// </summary>
    /// <remarks>
    /// The API is not the same as the normal task request, so a new SynologyRequest has to be created
    /// </remarks>
    public class TaskRequest : SynologyRequest
    {
        public TaskRequest(SynologyApi parentApi) : base(parentApi, "entry.cgi", "DownloadStation2.Task")
        {
        }

        /// <summary>
        /// Create a download by sending the file to the server (usually a torrent file)
        /// </summary>
        /// <param name="parameters">Parameters of the request</param>
        /// <returns>The result of the create task operation with task id and list id if requested.</returns>
        public ResultData<TaskCreateResult> Create(TaskCreateExParameters parameters)
        {
            return PostData<TaskCreateResult>(new SynologyPostParameters
            {
                Method = "create",
                Additional = parameters
            });
        }
    }
}
