using Newtonsoft.Json;

namespace Synology.FileStation.Common.Results
{
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
}
