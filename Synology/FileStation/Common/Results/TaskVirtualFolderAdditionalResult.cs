using Newtonsoft.Json;

namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task virtual folder additional result.
    /// </summary>
    public abstract class TaskVirtualFolderAdditionalResult<TVirtualFolderOwnerResult, TVirtualFolderTimeResult, TVirtualFolderPermResult, TVirtualFolderPermAclResult, TVirtualFolderVolumeStatusResult> : TaskAdditionalResult<TVirtualFolderOwnerResult, TVirtualFolderTimeResult, TVirtualFolderPermResult, TVirtualFolderPermAclResult>
        where TVirtualFolderOwnerResult : TaskVirtualFolderOwnerResult, new()
        where TVirtualFolderTimeResult : TaskVirtualFolderTimeResult, new()
        where TVirtualFolderPermResult : TaskVirtualFolderPermResult<TVirtualFolderPermAclResult>, new()
        where TVirtualFolderPermAclResult : TaskVirtualFolderPermAclResult, new()
        where TVirtualFolderVolumeStatusResult : TaskVirtualFolderVolumeStatusResult, new()
    {
        /// <summary>
        /// Gets or sets the volume status.
        /// </summary>
        /// <value>The volume status.</value>
        [JsonProperty("volume_status")]
        public TVirtualFolderVolumeStatusResult VolumeStatus { get; set; }
    }
}
