using Newtonsoft.Json;

namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task perm result.
    /// </summary>
    internal abstract class TaskPermResult<TPermAclResult> : ITaskPermResult<TPermAclResult>
        where TPermAclResult : TaskPermAclResult, new()
    {
        /// <summary>
        /// Gets or sets the posix.
        /// </summary>
        /// <value>The posix.</value>
        [JsonProperty("posix")]
        public int Posix { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Common.Results.TaskPermResult`1"/> is acl mode.
        /// </summary>
        /// <value><c>true</c> if is acl mode; otherwise, <c>false</c>.</value>
		[JsonProperty("is_acl_mode")]
        public bool IsAclMode { get; set; }

        /// <summary>
        /// Gets or sets the acl.
        /// </summary>
        /// <value>The acl.</value>
        [JsonProperty("acl")]
        public TPermAclResult Acl { get; set; }
    }

    /// <summary>
    /// Task file perm result.
    /// </summary>
    internal abstract class TaskFilePermResult<TFilePermAclResult> : TaskPermResult<TFilePermAclResult>, ITaskFilePermResult<TFilePermAclResult>
        where TFilePermAclResult : TaskFilePermAclResult, new()
    {
    }

    /// <summary>
    /// Task share perm result.
    /// </summary>
    internal abstract class TaskSharePermResult<TSharePermAclResult, TSharePermAdvRightResult> : TaskPermResult<TSharePermAclResult>, ITaskSharePermResult<TSharePermAclResult, TSharePermAdvRightResult>
        where TSharePermAclResult : TaskSharePermAclResult, new()
        where TSharePermAdvRightResult : TaskSharePermAdvRightResult, new()
    {
        /// <summary>
        /// Gets or sets the share right.
        /// </summary>
        /// <value>The share right.</value>
        [JsonProperty("share_right")]
        public string ShareRight { get; set; }

        /// <summary>
        /// Gets or sets the adv right.
        /// </summary>
        /// <value>The adv right.</value>
        [JsonProperty("adv_right")]
        public TSharePermAdvRightResult AdvRight { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Common.Results.TaskSharePermResult`2"/> acl enable.
        /// </summary>
        /// <value><c>true</c> if acl enable; otherwise, <c>false</c>.</value>
        [JsonProperty("acl_enable")]
        public bool AclEnable { get; set; }
    }

    /// <summary>
    /// Task virtual folder perm result.
    /// </summary>
    internal class TaskVirtualFolderPermResult<TVirtualFolderPermAclResult> : TaskPermResult<TVirtualFolderPermAclResult>, ITaskVirtualFolderPermResult<TVirtualFolderPermAclResult>
        where TVirtualFolderPermAclResult : TaskVirtualFolderPermAclResult, new()
    {
    }
}