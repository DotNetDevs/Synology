using Newtonsoft.Json;

namespace Synology.DownloadStation.Task.Results
{
	public class TaskFileResult
	{
        [JsonProperty("filename")]
		public string Filename { get; set; }

        [JsonProperty("size")]
		public string Size { get; set; }

		[JsonProperty("size_downloaded")]
		public string SizeDownloaded { get; set; }

        [JsonProperty("priority")]
		public string Priority { get; set; }
	}
}