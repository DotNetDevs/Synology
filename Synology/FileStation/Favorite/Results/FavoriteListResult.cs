using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Synology.FileStation.Favorite.Results
{
	public class FavoriteListResult
	{
        [JsonProperty("total")]
		public int Total { get; set; }

        [JsonProperty("offset")]
		public int Offset { get; set; }

        [JsonProperty("favorites")]
		public IEnumerable<FavoriteResult> Favorites { get; set; }
	}
}

