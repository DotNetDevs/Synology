using Synology.FileStation.Common.Results;

namespace Synology.FileStation.VirtualFolder.Results
{
    /// <summary>
    /// Virtual folder additional result.
    /// </summary>
    public interface IVirtualFolderAdditionalResult : ITaskVirtualFolderAdditionalResult<IVirtualFolderOwnerResult, IVirtualFolderTimeResult, IVirtualFolderPermResult, IVirtualFolderPermAclResult, IVirtualFolderVolumeStatusResult>
    {
    }
}