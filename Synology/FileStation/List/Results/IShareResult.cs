using Synology.FileStation.Common.Results;

namespace Synology.FileStation.List.Results
{
    /// <summary>
    /// Share result.
    /// </summary>
    public interface IShareResult : ITaskShareResult<IShareAdditionalResult, IShareOwnerResult, IShareTimeResult, ISharePermResult, ISharePermAclResult, IShareVolumeStatusResult, ISharePermAdvRightResult>
    {
    }
}