using System;
using Synology.Classes;
using Synology.Utilities;
using System.ComponentModel;
using Synology.FileStation.VirtualFolder.Parameters;
using Synology.FileStation.VirtualFolder.Results;

namespace Synology.FileStation.VirtualFolder
{
	public class VirtualFolderRequest : FileStationRequest
	{
		public VirtualFolderRequest(SynologyConnection connection) : base(connection, "file_virtual.cgi", "VirtualFolder")
		{
		}

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
				Method = "list",
				Additional = additionalParams
			});
		}
	}
}

