namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task share result.
    /// </summary>
    public interface ITaskShareResult<TShareAdditionalResult, TShareOwnerResult, TShareTimeResult, TSharePermResult, TSharePermAclResult, TShareVolumeStatusResult, TSharePermAdvRightResult> : ITaskResult<TShareAdditionalResult, TShareOwnerResult, TShareTimeResult, TSharePermResult, TSharePermAclResult>
        where TShareAdditionalResult : ITaskShareAdditionalResult<TShareOwnerResult, TShareTimeResult, TSharePermResult, TSharePermAclResult, TShareVolumeStatusResult, TSharePermAdvRightResult>
        where TShareOwnerResult : ITaskShareOwnerResult
        where TShareTimeResult : ITaskShareTimeResult
        where TSharePermResult : ITaskSharePermResult<TSharePermAclResult, TSharePermAdvRightResult>
        where TSharePermAclResult : ITaskSharePermAclResult
        where TShareVolumeStatusResult : ITaskShareVolumeStatusResult
        where TSharePermAdvRightResult : ITaskSharePermAdvRightResult
    {
    }
}
