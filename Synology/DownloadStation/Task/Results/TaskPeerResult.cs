using Newtonsoft.Json;

namespace Synology.DownloadStation.Task.Results
{
    /// <summary>
    /// Task peer result.
    /// </summary>
	internal class TaskPeerResult : ITaskPeerResult
	{
        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>
        [JsonProperty("address")]
		public string Address { get; set; }

        /// <summary>
        /// Gets or sets the agent.
        /// </summary>
        /// <value>The agent.</value>
        [JsonProperty("agent")]
		public string Agent { get; set; }

        /// <summary>
        /// Gets or sets the progress.
        /// </summary>
        /// <value>The progress.</value>
        [JsonProperty("progress")]
		public float Progress { get; set; }

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