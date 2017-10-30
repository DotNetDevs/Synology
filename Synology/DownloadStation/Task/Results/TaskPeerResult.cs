using Newtonsoft.Json;

namespace Synology.DownloadStation.Task.Results
{
	public class TaskPeerResult
	{
        [JsonProperty("address")]
		public string Address { get; set; }

        [JsonProperty("agent")]
		public string Agent { get; set; }

        [JsonProperty("progress")]
		public float Progress { get; set; }

		[JsonProperty("speed_download")]
		public int SpeedDownload { get; set; }

		[JsonProperty("speed_upload")]
		public int SpeedUpload { get; set; }
	}
}