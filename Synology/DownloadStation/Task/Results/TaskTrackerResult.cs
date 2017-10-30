using Newtonsoft.Json;

namespace Synology.DownloadStation.Task.Results
{
	public class TaskTrackerResult
	{
        [JsonProperty("url")]
		public string Url { get; set; }

        [JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("update_time")]
		public int UpdateTime { get; set; }

        [JsonProperty("seeds")]
		public int Seeds { get; set; }

        [JsonProperty("peers")]
		public int Peers { get; set; }
	}
}