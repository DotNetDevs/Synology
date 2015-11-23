using System.Collections.Generic;

namespace Synology.DownloadStation
{
	public class TaskListResult
	{
		public int Offset { get; set; }
		public IEnumerable<TaskResult> Tasks { get; set; }
		public int Total { get; set; }
	}
}
