using Newtonsoft.Json;

namespace Synology.FileStation.CopyMove.Results
{
    public class StartResult
    {
        [JsonProperty("taskid")]
        public string TaskId { get; set; }
    }
}
