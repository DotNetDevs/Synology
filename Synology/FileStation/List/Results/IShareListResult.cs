using Synology.FileStation.Common.Results;

namespace Synology.FileStation.List.Results
{
    /// <summary>
    /// Share list result.
    /// </summary>
    public interface IShareListResult : ITaskShareListResult<IShareAdditionalResult, IShareResult, IShareOwnerResult, IShareTimeResult, ISharePermResult, ISharePermAclResult, IShareVolumeStatusResult, ISharePermAdvRightResult>
    {
    }
}