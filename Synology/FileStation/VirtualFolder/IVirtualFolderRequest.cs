using System.ComponentModel;
using Synology.Classes;
using Synology.FileStation.VirtualFolder.Parameters;
using Synology.FileStation.VirtualFolder.Results;
using Synology.Interfaces;

namespace Synology.FileStation.VirtualFolder
{
    /// <summary>
    /// Virtual folder request.
    /// </summary>
    public interface IVirtualFolderRequest : ISynologyRequest
    {
        /// <summary>
        /// List the specified additional, type, offset, limit, sortBy and sortDirection.
        /// </summary>
        /// <returns>The list.</returns>
        /// <param name="additional">Additional.</param>
        /// <param name="type">Type.</param>
        /// <param name="offset">Offset.</param>
        /// <param name="limit">Limit.</param>
        /// <param name="sortBy">Sort by.</param>
        /// <param name="sortDirection">Sort direction.</param>
        ResultData<VirtualFolderListResult> List(VirtualFolderDetailsType? additional = null, VirtualFolderType? type = null, int offset = 0, int limit = 0, VirtualFolderSortType sortBy = VirtualFolderSortType.Name, ListSortDirection sortDirection = ListSortDirection.Ascending);
    }
}