using System;
using Newtonsoft.Json;

namespace Synology.FileStation.Favorite.Results
{
	public class FavoritePermAclResult
	{
        [JsonProperty("append")]
		public bool Append { get; set; }

        [JsonProperty("del")]
		public bool Delete { get; set; }

        [JsonProperty("exec")]
		public bool Execute { get; set; }

        [JsonProperty("read")]
		public bool Read { get; set; }

        [JsonProperty("write")]
		public bool Write { get; set; }
	}
}