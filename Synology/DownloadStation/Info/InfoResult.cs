using System;
using Newtonsoft.Json;

namespace Synology.DownloadStation.Info
{
	public class InfoResult
	{
		[JsonProperty("is_manager")]
		public bool IsManager { get; set; }

		public int Version { get; set; }

		[JsonProperty("version_string")]
		public string VersionString { get; set; }
	}
}