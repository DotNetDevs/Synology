using System.Collections.Generic;
using Newtonsoft.Json;

namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task share list result.
    /// </summary>
    public abstract class TaskShareListResult<TShareAdditionalResult, TShareResult, TShareOwnerResult, TShareTimeResult, TSharePermResult, TSharePermAclResult, TShareVolumeStatusResult, TSharePermAdvRightResult> : TaskListResult
        where TShareResult : TaskShareResult<TShareAdditionalResult, TShareOwnerResult, TShareTimeResult, TSharePermResult, TSharePermAclResult, TShareVolumeStatusResult, TSharePermAdvRightResult>, new()
        where TShareAdditionalResult : TaskShareAdditionalResult<TShareOwnerResult, TShareTimeResult, TSharePermResult, TSharePermAclResult, TShareVolumeStatusResult, TSharePermAdvRightResult>, new()
        where TShareOwnerResult : TaskShareOwnerResult, new()
        where TShareTimeResult : TaskShareTimeResult, new()
        where TSharePermResult : TaskSharePermResult<TSharePermAclResult, TSharePermAdvRightResult>, new()
        where TSharePermAclResult : TaskSharePermAclResult, new()
        where TShareVolumeStatusResult : TaskShareVolumeStatusResult, new()
        where TSharePermAdvRightResult : TaskSharePermAdvRightResult, new()
    {
        /// <summary>
        /// Gets or sets the shares.
        /// </summary>
        /// <value>The shares.</value>
        [JsonProperty("shares")]
        public IEnumerable<TShareResult> Shares { get; set; }
    }
}
