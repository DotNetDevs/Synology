using Newtonsoft.Json;

namespace Synology.DownloadStation.Schedule
{
	public class ScheduleResult
	{
		[JsonProperty("emule_enabled")]
		public bool EmuleEnabled { get; set; }

		public bool Enabled { get; set; }
	}
}

