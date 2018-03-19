using Newtonsoft.Json;

namespace Synology.FileStation.Favorite.Results
{
	public class FavoritePermResult
	{
        [JsonProperty("posix")]
		public int Posix { get; set; }

		[JsonProperty("is_acl_mode")]
		public bool IsAclMode { get; set; }

        [JsonProperty("acl")]
		public FavoritePermAclResult Acl { get; set; }
	}
}