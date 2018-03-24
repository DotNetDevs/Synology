using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Synology.DownloadStation.Task.Results
{
    /// <summary>
    /// Task additional result.
    /// </summary>
	internal class TaskAdditionalResult : ITaskAdditionalResult
	{
        /// <summary>
        /// Gets or sets the detail.
        /// </summary>
        /// <value>The detail.</value>
        [JsonProperty("detail")]
		public TaskDetailResult Detail { get; set; }
        ITaskDetailResult ITaskAdditionalResult.Detail => Detail;

        /// <summary>
        /// Gets or sets the transfer.
        /// </summary>
        /// <value>The transfer.</value>
        [JsonProperty("transfer")]
		public TaskTransferResult Transfer { get; set; }
        ITaskTransferResult ITaskAdditionalResult.Transfer => Transfer;

        /// <summary>
        /// Gets or sets the file.
        /// </summary>
        /// <value>The file.</value>
        [JsonProperty("file")]
		public IEnumerable<TaskFileResult> File { get; set; }
        IEnumerable<ITaskFileResult> ITaskAdditionalResult.File => File.Cast<ITaskFileResult>();

        /// <summary>
        /// Gets or sets the tracker.
        /// </summary>
        /// <value>The tracker.</value>
        [JsonProperty("tracker")]
		public IEnumerable<TaskTrackerResult> Tracker { get; set; }
        IEnumerable<ITaskTrackerResult> ITaskAdditionalResult.Tracker => Tracker.Cast<ITaskTrackerResult>();

        /// <summary>
        /// Gets or sets the peer.
        /// </summary>
        /// <value>The peer.</value>
        [JsonProperty("peer")]
		public IEnumerable<TaskPeerResult> Peer { get; set; }
        IEnumerable<ITaskPeerResult> ITaskAdditionalResult.Peer => Peer.Cast<ITaskPeerResult>();
	}
}