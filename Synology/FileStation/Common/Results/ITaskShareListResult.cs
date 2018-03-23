using System.Collections.Generic;

namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task share list result.
    /// </summary>
    public interface ITaskShareListResult<TShareAdditionalResult, TShareResult, TShareOwnerResult, TShareTimeResult, TSharePermResult, TSharePermAclResult, TShareVolumeStatusResult, TSharePermAdvRightResult>
        where TShareAdditionalResult : ITaskShareAdditionalResult<TShareOwnerResult, TShareTimeResult, TSharePermResult, TSharePermAclResult, TShareVolumeStatusResult, TSharePermAdvRightResult>
        where TShareResult : ITaskShareResult<TShareAdditionalResult, TShareOwnerResult, TShareTimeResult, TSharePermResult, TSharePermAclResult, TShareVolumeStatusResult, TSharePermAdvRightResult>
        where TShareOwnerResult : ITaskShareOwnerResult
        where TShareTimeResult : ITaskShareTimeResult
        where TSharePermResult : ITaskSharePermResult<TSharePermAclResult, TSharePermAdvRightResult>
        where TSharePermAclResult : ITaskSharePermAclResult
        where TShareVolumeStatusResult : ITaskShareVolumeStatusResult
        where TSharePermAdvRightResult : ITaskSharePermAdvRightResult
    {
        /// <summary>
        /// Gets the shares.
        /// </summary>
        /// <value>The shares.</value>
        IEnumerable<TShareResult> Shares { get; }
    }
}