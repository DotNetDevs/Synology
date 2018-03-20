using Newtonsoft.Json;

namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task start result.
    /// </summary>
    public abstract class TaskStartResult
    {
        /// <summary>
        /// Gets or sets the task identifier.
        /// </summary>
        /// <value>The task identifier.</value>
        [JsonProperty("taskid")]
        public string TaskId { get; set; }
    }
}
