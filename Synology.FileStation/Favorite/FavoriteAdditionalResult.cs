using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Dynamic;
using System.Configuration;

namespace Synology.FileStation.Favorite
{
	public class FavoriteAdditionalResult
	{
		[JsonProperty("real_path")]
		public string RealPath { get; set; }

		public FavoriteOwnerResult Owner { get; set; }

		public FavoriteTimeResult Time { get; set; }

		public FavoritePermResult Perm { get; set; }

		[JsonProperty("mount_point_type")]
		public string MountPointType { get; set; }

		public string Type { get; set; }
	}
}

