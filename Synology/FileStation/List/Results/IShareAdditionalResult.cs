using Synology.FileStation.Common.Results;

namespace Synology.FileStation.List.Results
{
    /// <summary>
    /// Share additional result.
    /// </summary>
    public interface IShareAdditionalResult : ITaskShareAdditionalResult<IShareOwnerResult, IShareTimeResult, ISharePermResult, ISharePermAclResult, IShareVolumeStatusResult, ISharePermAdvRightResult>
    {
    }
}