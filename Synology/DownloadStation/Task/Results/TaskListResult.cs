using System.Collections.Generic;
using Newtonsoft.Json;

namespace Synology.DownloadStation.Task.Results
{
	public class TaskListResult
	{
        [JsonProperty("offset")]
		public int Offset { get; set; }

        [JsonProperty("tasks")]
		public IEnumerable<TaskResult> Tasks { get; set; }

        [JsonProperty("total")]
		public int Total { get; set; }
	}
}
