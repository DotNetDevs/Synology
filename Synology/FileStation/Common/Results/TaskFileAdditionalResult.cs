using Newtonsoft.Json;

namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task file additional result.
    /// </summary>
    public abstract class TaskFileAdditionalResult<TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult> : TaskAdditionalResult<TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult>, ITaskFileAdditionalResult<TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult>
        where TFileOwnerResult : TaskFileOwnerResult, new()
        where TFileTimeResult : TaskFileTimeResult, new()
        where TFilePermResult : TaskFilePermResult<TFilePermAclResult>, new()
        where TFilePermAclResult : TaskFilePermAclResult, new()
    {
        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>The size.</value>
        [JsonProperty("size")]
        public long Size { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
