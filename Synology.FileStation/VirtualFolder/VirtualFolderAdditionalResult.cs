using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Dynamic;
using System.Configuration;

namespace Synology.FileStation.VirtualFolder
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

