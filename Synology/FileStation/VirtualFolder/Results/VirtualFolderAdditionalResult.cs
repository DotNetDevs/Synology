using Synology.FileStation.Common.Results;

namespace Synology.FileStation.VirtualFolder.Results
{
    /// <summary>
    /// Virtual folder additional result.
    /// </summary>
    internal class VirtualFolderAdditionalResult : TaskVirtualFolderAdditionalResult<VirtualFolderOwnerResult, VirtualFolderTimeResult, VirtualFolderPermResult, VirtualFolderPermAclResult, VirtualFolderVolumeStatusResult>, IVirtualFolderAdditionalResult
	{
        IVirtualFolderVolumeStatusResult ITaskVirtualFolderAdditionalResult<IVirtualFolderOwnerResult, IVirtualFolderTimeResult, IVirtualFolderPermResult, IVirtualFolderPermAclResult, IVirtualFolderVolumeStatusResult>.VolumeStatus => VolumeStatus;

        IVirtualFolderOwnerResult ITaskAdditionalResult<IVirtualFolderOwnerResult, IVirtualFolderTimeResult, IVirtualFolderPermResult, IVirtualFolderPermAclResult>.Owner => Owner;

        IVirtualFolderTimeResult ITaskAdditionalResult<IVirtualFolderOwnerResult, IVirtualFolderTimeResult, IVirtualFolderPermResult, IVirtualFolderPermAclResult>.Time => Time;

        IVirtualFolderPermResult ITaskAdditionalResult<IVirtualFolderOwnerResult, IVirtualFolderTimeResult, IVirtualFolderPermResult, IVirtualFolderPermAclResult>.Perm => Perm;
    }
}