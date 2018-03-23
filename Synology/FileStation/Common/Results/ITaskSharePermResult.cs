namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task share perm result.
    /// </summary>
    public interface ITaskSharePermResult<TSharePermAclResult, TSharePermAdvRightResult> : ITaskPermResult<TSharePermAclResult>
        where TSharePermAclResult : ITaskSharePermAclResult
        where TSharePermAdvRightResult : ITaskSharePermAdvRightResult
    {
        /// <summary>
        /// Gets the share right.
        /// </summary>
        /// <value>The share right.</value>
        string ShareRight { get; }
        /// <summary>
        /// Gets the adv right.
        /// </summary>
        /// <value>The adv right.</value>
        TSharePermAdvRightResult AdvRight { get; }
        /// <summary>
        /// Gets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Common.Results.ITaskSharePermResult`2"/> acl enable.
        /// </summary>
        /// <value><c>true</c> if acl enable; otherwise, <c>false</c>.</value>
        bool AclEnable { get; }
    }
}