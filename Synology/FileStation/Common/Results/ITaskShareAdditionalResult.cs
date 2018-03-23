namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task share additional result.
    /// </summary>
    public interface ITaskShareAdditionalResult<TShareOwnerResult, TShareTimeResult, TSharePermResult, TSharePermAclResult, TShareVolumeStatusResult, TSharePermAdvRightResult> : ITaskAdditionalResult<TShareOwnerResult, TShareTimeResult, TSharePermResult, TSharePermAclResult>
        where TShareOwnerResult : ITaskShareOwnerResult
        where TShareTimeResult : ITaskShareTimeResult
        where TSharePermResult : ITaskSharePermResult<TSharePermAclResult, TSharePermAdvRightResult>
        where TSharePermAclResult : ITaskSharePermAclResult
        where TShareVolumeStatusResult : ITaskShareVolumeStatusResult
        where TSharePermAdvRightResult : ITaskSharePermAdvRightResult
    {
        /// <summary>
        /// Gets the volume status.
        /// </summary>
        /// <value>The volume status.</value>
        TShareVolumeStatusResult VolumeStatus { get; }
    }
}