using Newtonsoft.Json;

namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task status result.
    /// </summary>
    internal abstract class TaskStatusResult : ITaskStatusResult
    {
        /// <summary>
        /// If the task is finished or not
        /// </summary>
        [JsonProperty("finished")]
        public bool Finished { get; set; }
    }
}
