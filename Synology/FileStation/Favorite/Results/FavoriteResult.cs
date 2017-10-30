using Newtonsoft.Json;

namespace Synology.FileStation.Favorite.Results
{
    public class FavoriteResult
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("additional")]
        public FavoriteAdditionalResult Additional { get; set; }
    }

}

