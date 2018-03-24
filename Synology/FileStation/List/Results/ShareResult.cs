using Synology.FileStation.Common.Results;

namespace Synology.FileStation.List.Results
{
    /// <summary>
    /// Share result.
    /// </summary>
    internal class ShareResult : TaskShareResult<ShareAdditionalResult, ShareOwnerResult, ShareTimeResult, SharePermResult, SharePermAclResult, ShareVolumeStatusResult, SharePermAdvRightResult>, IShareResult
    {
        IShareAdditionalResult ITaskResult<IShareAdditionalResult, IShareOwnerResult, IShareTimeResult, ISharePermResult, ISharePermAclResult>.Additional => Additional;
    }
}
