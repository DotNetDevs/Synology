using Newtonsoft.Json;

namespace Synology.DownloadStation.Task.Results
{
	public class TaskResult
	{
        [JsonProperty("id")]
		public string Id { get; set; }

        [JsonProperty("type")]
		public string Type { get; set; }

        [JsonProperty("username")]
		public string Username { get; set; }

        [JsonProperty("title")]
		public string Title { get; set; }

        [JsonProperty("size")]
		public string Size { get; set; }

        [JsonProperty("status")]
		public string Status { get; set; }

        [JsonProperty("additional")]
		public TaskAdditionalResult Additional { get; set; }

		[JsonProperty("status_extra")]
		public TaskStatusExtraResult StatusExtra { get; set; }
	}
}