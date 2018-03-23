using Newtonsoft.Json;

namespace Synology.DownloadStation.Schedule.Results
{
    /// <summary>
    /// Schedule result.
    /// </summary>
	internal class ScheduleResult : IScheduleResult
	{
        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.DownloadStation.Schedule.Results.ScheduleResult"/> emule enabled.
        /// </summary>
        /// <value><c>true</c> if emule enabled; otherwise, <c>false</c>.</value>
		[JsonProperty("emule_enabled")]
		public bool EmuleEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.DownloadStation.Schedule.Results.ScheduleResult"/> is enabled.
        /// </summary>
        /// <value><c>true</c> if enabled; otherwise, <c>false</c>.</value>
        [JsonProperty("enabled")]
		public bool Enabled { get; set; }
	}
}

