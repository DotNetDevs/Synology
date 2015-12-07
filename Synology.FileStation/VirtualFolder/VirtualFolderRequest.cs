using System;
using Synology.Classes;
using Synology.Utilities;
using System.ComponentModel;

namespace Synology.FileStation.VirtualFolder
{
	public class VirtualFolderRequest : SynologyRequest
	{
		public VirtualFolderRequest(SynologyConnection connection) : base(connection, "FileStation/file_virtual.cgi", "SYNO.FileStation.VirtualFolder")
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

