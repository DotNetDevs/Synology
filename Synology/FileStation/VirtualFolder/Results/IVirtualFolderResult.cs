using Synology.FileStation.Common.Results;

namespace Synology.FileStation.VirtualFolder.Results
{
    /// <summary>
    /// Virtual folder result.
    /// </summary>
    public interface IVirtualFolderResult : ITaskVirtualFolderResult<IVirtualFolderAdditionalResult, IVirtualFolderOwnerResult, IVirtualFolderTimeResult, IVirtualFolderPermResult, IVirtualFolderPermAclResult, IVirtualFolderVolumeStatusResult>
    {
    }
}