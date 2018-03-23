using Newtonsoft.Json;

namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task start result.
    /// </summary>
    internal abstract class TaskStartResult : ITaskStartResult
    {
        /// <summary>
        /// Gets or sets the task identifier.
        /// </summary>
        /// <value>The task identifier.</value>
        [JsonProperty("taskid")]
        public string TaskId { get; set; }
    }
}
