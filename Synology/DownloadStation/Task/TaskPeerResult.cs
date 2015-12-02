using Newtonsoft.Json;

namespace Synology.DownloadStation.Task
{
	public class TaskPeerResult
	{
		public string Address { get; set; }

		public string Agent { get; set; }

		public float Progress { get; set; }

		[JsonProperty("speed_download")]
		public int SpeedDownload { get; set; }

		[JsonProperty("speed_upload")]
		public int SpeedUpload { get; set; }
	}
}