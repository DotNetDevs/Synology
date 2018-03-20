using Newtonsoft.Json;

namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task additional result.
    /// </summary>
    public abstract class TaskAdditionalResult<TOwnerResult, TTimeResult, TPermResult, TPermAclResult> where TOwnerResult : TaskOwnerResult
        where TTimeResult : TaskTimeResult, new()
        where TPermResult : TaskPermResult<TPermAclResult>, new()
        where TPermAclResult : TaskPermAclResult, new()
    {
        /// <summary>
        /// Gets or sets the real path.
        /// </summary>
        /// <value>The real path.</value>
        [JsonProperty("real_path")]
        public string RealPath { get; set; }

        /// <summary>
        /// Gets or sets the owner.
        /// </summary>
        /// <value>The owner.</value>
        [JsonProperty("owner")]
        public TOwnerResult Owner { get; set; }

        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <value>The time.</value>
        [JsonProperty("time")]
        public TTimeResult Time { get; set; }

        /// <summary>
        /// Gets or sets the perm.
        /// </summary>
        /// <value>The perm.</value>
        [JsonProperty("perm")]
        public TPermResult Perm { get; set; }

        /// <summary>
        /// Gets or sets the type of the mount point.
        /// </summary>
        /// <value>The type of the mount point.</value>
        [JsonProperty("mount_point_type")]
        public string MountPointType { get; set; }
    }

    /// <summary>
    /// Task file additional result.
    /// </summary>
    public abstract class TaskFileAdditionalResult<TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult> : TaskAdditionalResult<TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult>
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

    /// <summary>
    /// Task share additional result.
    /// </summary>
    public abstract class TaskShareAdditionalResult<TShareOwnerResult, TShareTimeResult, TSharePermResult, TSharePermAclResult, TShareVolumeStatusResult, TSharePermAdvRightResult> : TaskAdditionalResult<TShareOwnerResult, TShareTimeResult, TSharePermResult, TSharePermAclResult>
        where TShareOwnerResult : TaskShareOwnerResult, new()
        where TShareTimeResult : TaskShareTimeResult, new()
        where TSharePermResult : TaskSharePermResult<TSharePermAclResult, TSharePermAdvRightResult>, new()
        where TSharePermAclResult : TaskSharePermAclResult, new()
        where TShareVolumeStatusResult : TaskShareVolumeStatusResult, new()
        where TSharePermAdvRightResult : TaskSharePermAdvRightResult, new()
    {
        /// <summary>
        /// Gets or sets the volume status.
        /// </summary>
        /// <value>The volume status.</value>
        [JsonProperty("volume_status")]
        public TShareVolumeStatusResult VolumeStatus { get; set; }
    }

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
