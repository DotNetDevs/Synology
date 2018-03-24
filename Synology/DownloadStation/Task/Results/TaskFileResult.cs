using Newtonsoft.Json;

namespace Synology.DownloadStation.Task.Results
{
    /// <summary>
    /// Task file result.
    /// </summary>
	internal class TaskFileResult : ITaskFileResult
	{
        /// <summary>
        /// Gets or sets the filename.
        /// </summary>
        /// <value>The filename.</value>
        [JsonProperty("filename")]
		public string Filename { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>The size.</value>
        [JsonProperty("size")]
		public string Size { get; set; }

        /// <summary>
        /// Gets or sets the size downloaded.
        /// </summary>
        /// <value>The size downloaded.</value>
		[JsonProperty("size_downloaded")]
		public string SizeDownloaded { get; set; }

        /// <summary>
        /// Gets or sets the priority.
        /// </summary>
        /// <value>The priority.</value>
        [JsonProperty("priority")]
		public string Priority { get; set; }
	}
}