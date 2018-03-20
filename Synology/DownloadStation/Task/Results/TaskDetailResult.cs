using Newtonsoft.Json;

namespace Synology.DownloadStation.Task.Results
{
    /// <summary>
    /// Task detail result.
    /// </summary>
	public class TaskDetailResult
	{
        /// <summary>
        /// Gets or sets the destination.
        /// </summary>
        /// <value>The destination.</value>
        [JsonProperty("destination")]
		public string Destination { get; set; }

        /// <summary>
        /// Gets or sets the URI.
        /// </summary>
        /// <value>The URI.</value>
        [JsonProperty("url")]
		public string Uri { get; set; }

        /// <summary>
        /// Gets or sets the create time.
        /// </summary>
        /// <value>The create time.</value>
		[JsonProperty("create_time")]
		public int CreateTime { get; set; }

        /// <summary>
        /// Gets or sets the priority.
        /// </summary>
        /// <value>The priority.</value>
        [JsonProperty("priority")]
		public string Priority { get; set; }

        /// <summary>
        /// Gets or sets the total peers.
        /// </summary>
        /// <value>The total peers.</value>
		[JsonProperty("total_peers")]
		public int TotalPeers { get; set; }

        /// <summary>
        /// Gets or sets the connected seeders.
        /// </summary>
        /// <value>The connected seeders.</value>
		[JsonProperty("connected_seeders")]
		public int ConnectedSeeders { get; set; }

        /// <summary>
        /// Gets or sets the connected leechers.
        /// </summary>
        /// <value>The connected leechers.</value>
		[JsonProperty("connected_leechers")]
		public int ConnectedLeechers { get; set; }
	}
}