using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Synology.FileStation.Favorite.Results
{
	public class FavoriteAdditionalResult
	{
		[JsonProperty("real_path")]
		public string RealPath { get; set; }

        [JsonProperty("owner")]
		public FavoriteOwnerResult Owner { get; set; }

        [JsonProperty("time")]
		public FavoriteTimeResult Time { get; set; }

        [JsonProperty("perm")]
		public FavoritePermResult Perm { get; set; }

		[JsonProperty("mount_point_type")]
		public string MountPointType { get; set; }

        [JsonProperty("type")]
		public string Type { get; set; }
	}
}

