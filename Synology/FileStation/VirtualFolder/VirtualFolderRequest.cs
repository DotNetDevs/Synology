using Synology.Classes;
using Synology.Utilities;
using System.ComponentModel;
using Synology.Attributes;
using Synology.FileStation.VirtualFolder.Parameters;
using Synology.FileStation.VirtualFolder.Results;
using Synology.Parameters;
using System.Threading.Tasks;
using System;

namespace Synology.FileStation.VirtualFolder
{
    [Request("VirtualFolder")]
    internal class VirtualFolderRequest : FileStationRequest, IVirtualFolderRequest
    {
        public VirtualFolderRequest(IFileStationApi api) : base(api)
        {
        }

        [RequestMethod("list")]
        public async Task<ResultData<IVirtualFolderListResult>> ListAsync(VirtualFolderDetailsType? additional = null, VirtualFolderType? type = null, int offset = 0, int limit = 0, VirtualFolderSortType sortBy = VirtualFolderSortType.Name, ListSortDirection sortDirection = ListSortDirection.Ascending)
        {
            var additionalParams = new[] {
                new QueryStringParameter("type", type),
                new QueryStringParameter("offset", offset),
                new QueryStringParameter("limit", limit),
                new QueryStringParameter("sort_by", sortBy),
                new QueryStringParameter("sort_direction", sortDirection),
                new QueryStringParameter("additional", additional)
            };

            return ResultData<IVirtualFolderListResult>.From(await this.GetDataAsync<VirtualFolderListResult>(new SynologyRequestParameters(this)
            {
                Additional = additionalParams
            }));
        }
    }
}

