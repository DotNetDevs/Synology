using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Synology.FileStation.VirtualFolder.Results
{
	public class VirtualFolderAdditionalResult
	{
		[JsonProperty("real_path")]
		public string RealPath { get; set; }

		public VirtualFolderOwnerResult Owner { get; set; }

		public VirtualFolderTimeResult Time { get; set; }

		public VirtualFolderPermResult Perm { get; set; }

		[JsonProperty("mount_point_type")]
		public string MountPointType { get; set; }

		[JsonProperty("volume_status")]
		public VirtualFolderVolumeStatusResult VolumeStatus { get; set; }
	}
}

