namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task additional result.
    /// </summary>
    public interface ITaskAdditionalResult<TOwnerResult, TTimeResult, TPermResult, TPermAclResult>
        where TOwnerResult : TaskOwnerResult
        where TTimeResult : TaskTimeResult, new()
        where TPermResult : TaskPermResult<TPermAclResult>, new()
        where TPermAclResult : TaskPermAclResult, new()
    {
        /// <summary>
        /// Gets or sets the real path.
        /// </summary>
        /// <value>The real path.</value>
        string RealPath { get; set; }
        /// <summary>
        /// Gets or sets the owner.
        /// </summary>
        /// <value>The owner.</value>
        TOwnerResult Owner { get; set; }
        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <value>The time.</value>
        TTimeResult Time { get; set; }
        /// <summary>
        /// Gets or sets the perm.
        /// </summary>
        /// <value>The perm.</value>
        TPermResult Perm { get; set; }
        /// <summary>
        /// Gets or sets the type of the mount point.
        /// </summary>
        /// <value>The type of the mount point.</value>
        string MountPointType { get; set; }
    }
}