using System;
using Newtonsoft.Json;

namespace Synology.DownloadStation.Task.Results
{
	public class TaskMinimalResult
	{
        [JsonProperty("id")]
		public string Id { get; set; }

        [JsonProperty("error")]
		public int Error{ get; set; }
	}
}

