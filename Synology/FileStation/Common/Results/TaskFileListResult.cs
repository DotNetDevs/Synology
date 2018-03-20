using System.Collections.Generic;
using Newtonsoft.Json;

namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task file list result.
    /// </summary>
    public abstract class TaskFileListResult<TFileResult, TFileListResult, TFileAdditionalResult, TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult> : TaskListResult
        where TFileListResult : TaskFileListResult<TFileResult, TFileListResult, TFileAdditionalResult, TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult>, new()
        where TFileAdditionalResult : TaskFileAdditionalResult<TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult>, new()
        where TFileOwnerResult : TaskFileOwnerResult, new()
        where TFileTimeResult : TaskFileTimeResult, new()
        where TFilePermResult : TaskFilePermResult<TFilePermAclResult>, new()
        where TFilePermAclResult : TaskFilePermAclResult, new()
        where TFileResult : TaskFileResult<TFileListResult, TFileAdditionalResult, TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult, TFileResult>, new()
    {
        /// <summary>
        /// Gets or sets the files.
        /// </summary>
        /// <value>The files.</value>
        [JsonProperty("files")]
        public IEnumerable<TFileResult> Files { get; set; }
    }
}
