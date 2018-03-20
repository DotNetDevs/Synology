using System.Collections.Generic;
using Newtonsoft.Json;

namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task virtual folder list result.
    /// </summary>
    public abstract class TaskVirtualFolderListResult<TVirtualFolderResult, TVirtualFolderAdditionalResult, TVirtualFolderOwnerResult, TVirtualFolderTimeResult, TVirtualFolderPermResult, TVirtualFolderPermAclResult, TVirtualFolderVolumeStatusResult> : TaskListResult
        where TVirtualFolderResult : TaskVirtualFolderResult<TVirtualFolderAdditionalResult, TVirtualFolderOwnerResult, TVirtualFolderTimeResult, TVirtualFolderPermResult, TVirtualFolderPermAclResult, TVirtualFolderVolumeStatusResult>, new()
        where TVirtualFolderAdditionalResult : TaskVirtualFolderAdditionalResult<TVirtualFolderOwnerResult, TVirtualFolderTimeResult, TVirtualFolderPermResult, TVirtualFolderPermAclResult, TVirtualFolderVolumeStatusResult>, new()
        where TVirtualFolderOwnerResult : TaskVirtualFolderOwnerResult, new()
        where TVirtualFolderTimeResult : TaskVirtualFolderTimeResult, new()
        where TVirtualFolderPermResult : TaskVirtualFolderPermResult<TVirtualFolderPermAclResult>, new()
        where TVirtualFolderPermAclResult : TaskVirtualFolderPermAclResult, new()
        where TVirtualFolderVolumeStatusResult : TaskVirtualFolderVolumeStatusResult, new()
    {
        /// <summary>
        /// Gets or sets the folders.
        /// </summary>
        /// <value>The folders.</value>
        [JsonProperty("folders")]
        public IEnumerable<TVirtualFolderResult> Folders { get; set; }
    }
}
