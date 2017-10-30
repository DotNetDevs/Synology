using System;
using Newtonsoft.Json;

namespace Synology.DownloadStation.Task.Results
{
	public class TaskDetailResult
	{
        [JsonProperty("destination")]
		public string Destination { get; set; }

        [JsonProperty("url")]
		public string Uri { get; set; }

		[JsonProperty("create_time")]
		public int CreateTime { get; set; }

        [JsonProperty("priority")]
		public string Priority { get; set; }

		[JsonProperty("total_peers")]
		public int TotalPeers { get; set; }

		[JsonProperty("connected_seeders")]
		public int ConnectedSeeders { get; set; }

		[JsonProperty("connected_leechers")]
		public int ConnectedLeechers { get; set; }
	}
}