using Synology.FileStation.Common.Results;

namespace Synology.FileStation.VirtualFolder.Results
{
    /// <summary>
    /// Virtual folder result.
    /// </summary>
    internal class VirtualFolderResult : TaskVirtualFolderResult<VirtualFolderAdditionalResult, VirtualFolderOwnerResult, VirtualFolderTimeResult, VirtualFolderPermResult, VirtualFolderPermAclResult, VirtualFolderVolumeStatusResult>, IVirtualFolderResult
	{
        IVirtualFolderAdditionalResult ITaskResult<IVirtualFolderAdditionalResult, IVirtualFolderOwnerResult, IVirtualFolderTimeResult, IVirtualFolderPermResult, IVirtualFolderPermAclResult>.Additional => Additional;
    }
}