using System.Collections.Generic;
using System.Linq;
using Synology.FileStation.Common.Results;

namespace Synology.FileStation.VirtualFolder.Results
{

    /// <summary>
    /// Virtual folder list result.
    /// </summary>
    internal class VirtualFolderListResult : TaskVirtualFolderListResult<VirtualFolderResult, VirtualFolderAdditionalResult, VirtualFolderOwnerResult, VirtualFolderTimeResult, VirtualFolderPermResult, VirtualFolderPermAclResult, VirtualFolderVolumeStatusResult>, IVirtualFolderListResult
	{
        IEnumerable<IVirtualFolderResult> ITaskVirtualFolderListResult<IVirtualFolderResult, IVirtualFolderAdditionalResult, IVirtualFolderOwnerResult, IVirtualFolderTimeResult, IVirtualFolderPermResult, IVirtualFolderPermAclResult, IVirtualFolderVolumeStatusResult>.Folders => Folders.Cast<IVirtualFolderResult>();
    }
}

