using System;
using Newtonsoft.Json;

namespace Synology.FileStation.Favorite.Results
{
	public class FavoriteOwnerResult
	{
        [JsonProperty("user")]
		public string User { get; set; }

        [JsonProperty("group")]
		public string Group { get; set; }

        [JsonProperty("uid")]
		public int Uid { get; set; }

        [JsonProperty("gid")]
		public int Gid { get; set; }
	}
}