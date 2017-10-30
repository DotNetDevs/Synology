using System.ComponentModel;
using Synology.Classes;
using Synology.FileStation.VirtualFolder.Parameters;
using Synology.FileStation.VirtualFolder.Results;
using Synology.Interfaces;

namespace Synology.FileStation.VirtualFolder
{
    public interface IVirtualFolderRequest : ISynologyRequest
    {
        ResultData<VirtualFolderListResult> List(VirtualFolderDetailsType? additional = null, VirtualFolderType? type = null, int offset = 0, int limit = 0, VirtualFolderSortType sortBy = VirtualFolderSortType.Name, ListSortDirection sortDirection = ListSortDirection.Ascending);
    }
}