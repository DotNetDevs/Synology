using Newtonsoft.Json;

namespace Synology.DownloadStation.Task.Results
{
    /// <summary>
    /// Task transfer result.
    /// </summary>
	public class TaskTransferResult
	{
        /// <summary>
        /// Gets or sets the size downloaded.
        /// </summary>
        /// <value>The size downloaded.</value>
		[JsonProperty("size_downloaded")]
		public string SizeDownloaded { get; set; }

        /// <summary>
        /// Gets or sets the size uploaded.
        /// </summary>
        /// <value>The size uploaded.</value>
		[JsonProperty("size_uploaded")]
		public string SizeUploaded { get; set; }

        /// <summary>
        /// Gets or sets the speed download.
        /// </summary>
        /// <value>The speed download.</value>
		[JsonProperty("speed_download")]
		public int SpeedDownload { get; set; }

        /// <summary>
        /// Gets or sets the speed upload.
        /// </summary>
        /// <value>The speed upload.</value>
		[JsonProperty("speed_upload")]
		public int SpeedUpload { get; set; }
	}
}