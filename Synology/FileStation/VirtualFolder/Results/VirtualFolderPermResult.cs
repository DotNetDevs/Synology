using Synology.FileStation.Common.Results;

namespace Synology.FileStation.VirtualFolder.Results
{
    /// <summary>
    /// Virtual folder perm result.
    /// </summary>
    internal class VirtualFolderPermResult : TaskVirtualFolderPermResult<VirtualFolderPermAclResult>, IVirtualFolderPermResult
	{
        IVirtualFolderPermAclResult ITaskPermResult<IVirtualFolderPermAclResult>.Acl => Acl;
    }
}