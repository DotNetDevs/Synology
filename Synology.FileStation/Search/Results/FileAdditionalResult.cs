using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Dynamic;
using System.Configuration;

namespace Synology.FileStation.Search.Results
{
	public class FileAdditionalResult
	{
		[JsonProperty("real_path")]
		public string RealPath { get; set; }

		public long Size { get; set; }

		public FileOwnerResult Owner { get; set; }

		public FileTimeResult Time { get; set; }

		public FilePermResult Perm { get; set; }

		[JsonProperty("mount_point_type")]
		public string MountPointType { get; set; }

		public string Type { get; set; }
	}
}

