using Newtonsoft.Json;

namespace Synology.FileStation.Common.Results
{
    public abstract class TaskStatusResult
    {
        /// <summary>
        /// If the task is finished or not
        /// </summary>
        [JsonProperty("finished")]
        public bool Finished { get; set; }
    }
}
