using Newtonsoft.Json;

namespace Synology.DownloadStation.Schedule.Results
{
	public class ScheduleResult
	{
		[JsonProperty("emule_enabled")]
		public bool EmuleEnabled { get; set; }

        [JsonProperty("enabled")]
		public bool Enabled { get; set; }
	}
}

