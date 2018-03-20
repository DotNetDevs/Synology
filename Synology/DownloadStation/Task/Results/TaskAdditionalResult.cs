using System.Collections.Generic;
using Newtonsoft.Json;

namespace Synology.DownloadStation.Task.Results
{
    /// <summary>
    /// Task additional result.
    /// </summary>
	public class TaskAdditionalResult
	{
        /// <summary>
        /// Gets or sets the detail.
        /// </summary>
        /// <value>The detail.</value>
        [JsonProperty("detail")]
		public TaskDetailResult Detail { get; set; }

        /// <summary>
        /// Gets or sets the transfer.
        /// </summary>
        /// <value>The transfer.</value>
        [JsonProperty("transfer")]
		public TaskTransferResult Transfer { get; set; }

        /// <summary>
        /// Gets or sets the file.
        /// </summary>
        /// <value>The file.</value>
        [JsonProperty("file")]
		public IEnumerable<TaskFileResult> File { get; set; }

        /// <summary>
        /// Gets or sets the tracker.
        /// </summary>
        /// <value>The tracker.</value>
        [JsonProperty("tracker")]
		public IEnumerable<TaskTrackerResult> Tracker { get; set; }

        /// <summary>
        /// Gets or sets the peer.
        /// </summary>
        /// <value>The peer.</value>
        [JsonProperty("peer")]
		public IEnumerable<TaskPeerResult> Peer { get; set; }
	}
}