using Synology.FileStation.Common.Results;

namespace Synology.FileStation.FileShare.Results
{
    /// <summary>
    /// Share additional result.
    /// </summary>
    internal class ShareAdditionalResult : TaskShareAdditionalResult<ShareOwnerResult, ShareTimeResult, SharePermResult, SharePermAclResult, ShareVolumeStatusResult, SharePermAdvRightResult>, IShareAdditionalResult
	{
        IShareVolumeStatusResult ITaskShareAdditionalResult<IShareOwnerResult, IShareTimeResult, ISharePermResult, ISharePermAclResult, IShareVolumeStatusResult, ISharePermAdvRightResult>.VolumeStatus => VolumeStatus;

        IShareOwnerResult ITaskAdditionalResult<IShareOwnerResult, IShareTimeResult, ISharePermResult, ISharePermAclResult>.Owner => Owner;

        IShareTimeResult ITaskAdditionalResult<IShareOwnerResult, IShareTimeResult, ISharePermResult, ISharePermAclResult>.Time => Time;

        ISharePermResult ITaskAdditionalResult<IShareOwnerResult, IShareTimeResult, ISharePermResult, ISharePermAclResult>.Perm => Perm;
    }
}

