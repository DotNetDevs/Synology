using Newtonsoft.Json;

namespace Synology.DownloadStation
{
	public class TaskTransferResult
	{
		[JsonProperty("size_downloaded")]
		public string SizeDownloaded { get; set; }
		[JsonProperty("size_uploaded")]
		public string SizeUploaded { get; set; }
		[JsonProperty("speed_download")]
		public int SpeedDownload { get; set; }
		[JsonProperty("speed_upload")]
		public int SpeedUpload { get; set; }
	}
}