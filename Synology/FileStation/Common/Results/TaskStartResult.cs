using System;
using Newtonsoft.Json;

namespace Synology.FileStation.Common.Results
{
    public abstract class TaskStartResult
    {
        [JsonProperty("taskid")]
        public string TaskId { get; set; }
    }
}
