using System;
using Newtonsoft.Json;

namespace Synology.FileStation.Favorite.Results
{
	public class FavoriteTimeResult
	{
        [JsonProperty("atime")]
		public int Atime { get; set; }

        [JsonProperty("mtime")]
		public int Mtime { get; set; }

        [JsonProperty("ctime")]
		public int Ctime { get; set; }

        [JsonProperty("crtime")]
		public int CrTime { get; set; }
	}
}