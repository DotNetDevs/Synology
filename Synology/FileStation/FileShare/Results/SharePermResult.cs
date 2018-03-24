using Synology.FileStation.Common.Results;

namespace Synology.FileStation.FileShare.Results
{
    /// <summary>
    /// Share perm result.
    /// </summary>
    internal class SharePermResult : TaskSharePermResult<SharePermAclResult, SharePermAdvRightResult>, ISharePermResult
	{
        ISharePermAdvRightResult ITaskSharePermResult<ISharePermAclResult, ISharePermAdvRightResult>.AdvRight => AdvRight;

        ISharePermAclResult ITaskPermResult<ISharePermAclResult>.Acl => Acl;
    }
}