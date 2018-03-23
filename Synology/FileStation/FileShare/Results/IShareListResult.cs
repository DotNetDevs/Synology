using Synology.FileStation.Common.Results;

namespace Synology.FileStation.FileShare.Results
{
    /// <summary>
    /// Share list result.
    /// </summary>
    public interface IShareListResult : ITaskShareListResult<IShareAdditionalResult, IShareResult, IShareOwnerResult, IShareTimeResult, ISharePermResult, ISharePermAclResult, IShareVolumeStatusResult, ISharePermAdvRightResult>
    {
    }
}