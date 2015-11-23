using System;
using Newtonsoft.Json;

namespace Synology.FileStation
{
	public class SharePermAdvRightResult
	{
		[JsonProperty("disable_download")]
		public bool DisableDownload { get; set; }

		[JsonProperty("disable_list")]
		public bool DisableList { get; set; }

		[JsonProperty("disable_modify")]
		public bool DisableModify { get; set; }
	}
}