using Newtonsoft.Json;
using Synology.Interfaces;

namespace Synology.Api.Info.Results
{
    public class ApiInfo : IApiInfo
    {
        [JsonProperty("path")]
        public string Path { get; internal set; }
        [JsonProperty("minVersion")]
        public int MinVersion { get; internal set; }
        [JsonProperty("maxVersion")]
        public int MaxVersion { get; internal set; }
    }
}

