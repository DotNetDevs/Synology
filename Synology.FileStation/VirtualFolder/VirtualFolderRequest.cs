using System;
using Synology.Classes;
using Synology.Utilities;
using System.ComponentModel;
using Synology.Attributes;
using Synology.FileStation.VirtualFolder.Parameters;
using Synology.FileStation.VirtualFolder.Results;
using Synology.Parameters;

namespace Synology.FileStation.VirtualFolder
{
    public class VirtualFolderRequest : FileStationRequest
    {
        public VirtualFolderRequest(SynologyApi api) : base(api, "VirtualFolder")
        {
        }

        [RequestMethod("list")]
        public ResultData<VirtualFolderListResult> List(VirtualFolderDetailsType? additional = null, VirtualFolderType? type = null, int offset = 0, int limit = 0, VirtualFolderSortType sortBy = VirtualFolderSortType.Name, ListSortDirection sortDirection = ListSortDirection.Ascending)
        {
            var additionalParams = new[] {
                new QueryStringParameter("type", type),
                new QueryStringParameter("offset", offset),
                new QueryStringParameter("limit", limit),
                new QueryStringParameter("sort_by", sortBy),
                new QueryStringParameter("sort_direction", sortDirection),
                new QueryStringParameter("additional", additional)
            };

            return GetData<VirtualFolderListResult>(new SynologyRequestParameters
            {
                Additional = additionalParams
            });
        }
    }
}

