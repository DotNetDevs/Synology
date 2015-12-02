using System;
using Newtonsoft.Json;

namespace Synology.FileStation.FileShare
{
	public class ShareAdditionalResult
	{
		[JsonProperty("real_path")]
		public string RealPath { get; set; }

		public ShareOwnerResult Owner { get; set; }

		public ShareTimeResult Time { get; set; }

		public SharePermResult Perm { get; set; }

		[JsonProperty("mount_point_type")]
		public string MountPointType { get; set; }

		[JsonProperty("volume_status")]
		public ShareVolumeStatusResult VolumeStatus { get; set; }
	}
}

