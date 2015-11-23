using Newtonsoft.Json;

namespace Synology.DownloadStation
{
	public class TaskResult
	{
		public string Id { get; set; }
		public string Type { get; set; }
		public int Username { get; set; }
		public string Title { get; set; }
		public string Size { get; set; }
		public string Status { get; set; }
		public TaskAdditionalResult Additional { get; set; }
		[JsonProperty("status_extra")]
		public TaskStatusExtraResult StatusExtra { get; set; }
	}
}