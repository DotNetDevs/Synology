using System;
using Newtonsoft.Json;

namespace Synology.FileStation.Favorite
{
	public class FavoritePermResult
	{
		public int Posix { get; set; }

		[JsonProperty("is_acl_mode")]
		public bool IsAclMode { get; set; }

		public FavoritePermAclResult Acl { get; set; }
	}
}