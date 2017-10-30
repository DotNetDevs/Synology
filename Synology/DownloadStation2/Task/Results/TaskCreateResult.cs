using Newtonsoft.Json;
using System.Collections.Generic;

namespace Synology.DownloadStation2.Task.Results
{
    public class TaskCreateResult
    {
        [JsonProperty("list_id")]
        public IEnumerable<string> ListIds { get; set; }

        [JsonProperty("task_id")]
        public IEnumerable<string> TaskIds { get; set; }
    }
}
