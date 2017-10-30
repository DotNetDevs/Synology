using System.Collections.Generic;
using Newtonsoft.Json;

namespace Synology.DownloadStation.Task.Results
{
	public class TaskAdditionalResult
	{
        [JsonProperty("detail")]
		public TaskDetailResult Detail { get; set; }

        [JsonProperty("transfer")]
		public TaskTransferResult Transfer { get; set; }

        [JsonProperty("file")]
		public IEnumerable<TaskFileResult> File { get; set; }

        [JsonProperty("tracker")]
		public IEnumerable<TaskTrackerResult> Tracker { get; set; }

        [JsonProperty("peer")]
		public IEnumerable<TaskPeerResult> Peer { get; set; }
	}
}