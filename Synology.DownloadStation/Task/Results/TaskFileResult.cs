using Newtonsoft.Json;

namespace Synology.DownloadStation.Task.Results
{
	public class TaskFileResult
	{
		public string Filename { get; set; }

		public string Size { get; set; }

		[JsonProperty("size_downloaded")]
		public string SizeDownloaded { get; set; }

		public string Priority { get; set; }
	}
}