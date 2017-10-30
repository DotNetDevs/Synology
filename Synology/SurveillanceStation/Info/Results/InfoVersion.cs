using System;
using Newtonsoft.Json;

namespace Synology.SurveillanceStation.Info.Results
{
    public class InfoVersion
    {
        [JsonProperty("major")]
        public int Major { get; set; }

        [JsonProperty("minor")]
        public int Minor { get; set; }

        [JsonProperty("build")]
        public int Build { get; set; }
    }
}