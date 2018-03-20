using Newtonsoft.Json;

namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task additional result.
    /// </summary>
    public abstract class TaskAdditionalResult<TOwnerResult, TTimeResult, TPermResult, TPermAclResult> : ITaskAdditionalResult<TOwnerResult, TTimeResult, TPermResult, TPermAclResult> where TOwnerResult : TaskOwnerResult
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
}
