using System.Collections.Generic;

namespace Synology.DownloadStation.Task.Results
{
	public class TaskAdditionalResult
	{
		public TaskDetailResult Detail { get; set; }

		public TaskTransferResult Transfer { get; set; }

		public IEnumerable<TaskFileResult> File { get; set; }

		public IEnumerable<TaskTrackerResult> Tracker { get; set; }

		public IEnumerable<TaskPeerResult> Peer { get; set; }
	}
}