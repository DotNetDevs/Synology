using Newtonsoft.Json;

namespace Synology.DownloadStation.Task.Results
{
    /// <summary>
    /// Task tracker result.
    /// </summary>
	internal class TaskTrackerResult : ITaskTrackerResult
	{
        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>The URL.</value>
        [JsonProperty("url")]
		public string Url { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
        [JsonProperty("status")]
		public string Status { get; set; }

        /// <summary>
        /// Gets or sets the update time.
        /// </summary>
        /// <value>The update time.</value>
		[JsonProperty("update_time")]
		public int UpdateTime { get; set; }

        /// <summary>
        /// Gets or sets the seeds.
        /// </summary>
        /// <value>The seeds.</value>
        [JsonProperty("seeds")]
		public int Seeds { get; set; }

        /// <summary>
        /// Gets or sets the peers.
        /// </summary>
        /// <value>The peers.</value>
        [JsonProperty("peers")]
		public int Peers { get; set; }
	}
}