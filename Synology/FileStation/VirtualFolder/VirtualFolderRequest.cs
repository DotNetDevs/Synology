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
        [Obsolete("It uses Result, migrate to Async methods")]
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

            return this.GetData<VirtualFolderListResult>(new SynologyRequestParameters(this)
			{
				Additional = additionalParams
			});
		}

        [RequestMethod("list")]
        public async Task<ResultData<VirtualFolderListResult>> ListAsync(VirtualFolderDetailsType? additional = null, VirtualFolderType? type = null, int offset = 0, int limit = 0, VirtualFolderSortType sortBy = VirtualFolderSortType.Name, ListSortDirection sortDirection = ListSortDirection.Ascending)
        {
            var additionalParams = new[] {
                new QueryStringParameter("type", type),
                new QueryStringParameter("offset", offset),
                new QueryStringParameter("limit", limit),
                new QueryStringParameter("sort_by", sortBy),
                new QueryStringParameter("sort_direction", sortDirection),
                new QueryStringParameter("additional", additional)
            };

            return await this.GetDataAsync<VirtualFolderListResult>(new SynologyRequestParameters(this)
            {
                Additional = additionalParams
            });
        }
	}
}

