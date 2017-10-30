using Newtonsoft.Json;

namespace Synology.FileStation.Common.Results
{
    public abstract class TaskSharePermAdvRightResult
	{
		[JsonProperty("disable_download")]
		public bool DisableDownload { get; set; }

		[JsonProperty("disable_list")]
		public bool DisableList { get; set; }

		[JsonProperty("disable_modify")]
		public bool DisableModify { get; set; }
	}
}