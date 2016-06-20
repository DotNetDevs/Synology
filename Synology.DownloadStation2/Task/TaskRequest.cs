﻿using Synology.Classes;
using Synology.DownloadStation2.Task.Parameters;
using Synology.DownloadStation2.Task.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Synology.Attributes;
using Synology.Parameters;

namespace Synology.DownloadStation2.Task
{
    /// <summary>
    /// Task (Extended) returning the ids of the downloads.
    /// </summary>
    /// <remarks>
    /// The API is not the same as the normal task request, so a new SynologyRequest has to be created
    /// </remarks>
    [Request("Task")]
    public class TaskRequest : DownloadStation2Request
    {
        public TaskRequest(SynologyApi parentApi) : base(parentApi, "Task")
        {
        }

        /// <summary>
        /// Create a download by sending the file to the server (usually a torrent file)
        /// </summary>
        /// <param name="parameters">Parameters of the request</param>
        /// <returns>The result of the create task operation with task id and list id if requested.</returns>
        [RequestMethod("create")]
        public ResultData<TaskCreateResult> Create(TaskCreateParameters parameters)
        {
            return PostData<TaskCreateResult>(new SynologyPostParameters
            {
                Method = "create",
                Additional = parameters
            });
        }
    }
}
