namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task perm result.
    /// </summary>
    public interface ITaskPermResult<TPermAclResult> where TPermAclResult : ITaskPermAclResult
    {
        /// <summary>
        /// Gets the posix.
        /// </summary>
        /// <value>The posix.</value>
        int Posix { get; }
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:Synology.FileStation.Common.Results.ITaskPermResult`1"/>
        /// is acl mode.
        /// </summary>
        /// <value><c>true</c> if is acl mode; otherwise, <c>false</c>.</value>
        bool IsAclMode { get; }
        /// <summary>
        /// Gets the acl.
        /// </summary>
        /// <value>The acl.</value>
        TPermAclResult Acl { get; }
    }
}