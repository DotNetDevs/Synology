using System;
using Newtonsoft.Json;

namespace Synology.FileStation
{
	public class InfoResult
	{
		[JsonProperty("is_manager")]
		public bool IsManager { get; set; }

		[JsonProperty("support_virtual")]
		public string SupportVirtual { get; set; }

		[JsonProperty("support_sharing")]
		public bool SupportSharing { get; set; }

		public string Hostname { get; set; }
	}
}

