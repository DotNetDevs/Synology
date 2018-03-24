using Synology.FileStation.Common.Results;

namespace Synology.FileStation.VirtualFolder.Results
{
    /// <summary>
    /// Virtual folder list result.
    /// </summary>
    public interface IVirtualFolderListResult : ITaskVirtualFolderListResult<IVirtualFolderResult, IVirtualFolderAdditionalResult, IVirtualFolderOwnerResult, IVirtualFolderTimeResult, IVirtualFolderPermResult, IVirtualFolderPermAclResult, IVirtualFolderVolumeStatusResult>
    {
    }
}