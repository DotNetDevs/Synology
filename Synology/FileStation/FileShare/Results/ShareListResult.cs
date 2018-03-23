using System.Collections.Generic;
using System.Linq;
using Synology.FileStation.Common.Results;

namespace Synology.FileStation.FileShare.Results
{
    /// <summary>
    /// Share list result.
    /// </summary>
    internal class ShareListResult : TaskShareListResult<ShareAdditionalResult, ShareResult, ShareOwnerResult, ShareTimeResult, SharePermResult, SharePermAclResult, ShareVolumeStatusResult, SharePermAdvRightResult>, IShareListResult
	{
        IEnumerable<IShareResult> ITaskShareListResult<IShareAdditionalResult, IShareResult, IShareOwnerResult, IShareTimeResult, ISharePermResult, ISharePermAclResult, IShareVolumeStatusResult, ISharePermAdvRightResult>.Shares => Shares.Cast<IShareResult>();
    }
}

