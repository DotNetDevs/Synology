using Newtonsoft.Json;

namespace Synology.DownloadStation
{
	public class ScheduleResult
	{
		[JsonProperty("emule_enabled")]
		public bool EmuleEnabled { get; set; }

		public bool Enabled { get; set; }
	}
}

