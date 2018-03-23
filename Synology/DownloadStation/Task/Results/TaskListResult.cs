using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Synology.DownloadStation.Task.Results
{
    /// <summary>
    /// Task list result.
    /// </summary>
	internal class TaskListResult : ITaskListResult
	{
        /// <summary>
        /// Gets or sets the offset.
        /// </summary>
        /// <value>The offset.</value>
        [JsonProperty("offset")]
		public int Offset { get; set; }

        /// <summary>
        /// Gets or sets the tasks.
        /// </summary>
        /// <value>The tasks.</value>
        [JsonProperty("tasks")]
		public IEnumerable<TaskResult> Tasks { get; set; }
        IEnumerable<ITaskResult> ITaskListResult.Tasks => Tasks.Cast<ITaskResult>();

        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        /// <value>The total.</value>
        [JsonProperty("total")]
		public int Total { get; set; }
	}
}
