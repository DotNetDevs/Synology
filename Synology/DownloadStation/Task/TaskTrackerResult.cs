using Newtonsoft.Json;

namespace Synology.DownloadStation.Task
{
	public class TaskTrackerResult
	{
		public string Url { get; set; }

		public string Status { get; set; }

		[JsonProperty("update_time")]
		public int UpdateTime { get; set; }

		public int Seeds { get; set; }

		public int Peers { get; set; }
	}
}