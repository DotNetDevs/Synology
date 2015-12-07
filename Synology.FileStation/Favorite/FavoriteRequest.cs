using System;
using Synology.Classes;
using Synology.Utilities;
using System.ComponentModel;

namespace Synology.FileStation.Favorite
{
	public class FavoriteRequest : SynologyRequest
	{
		public FavoriteRequest(SynologyConnection connection) : base(connection, "FileStation/file_virtual.cgi", "SYNO.FileStation.VirtualFolder")
		{
		}

		public ResultData<FavoriteListResult> List(FavoriteDetailsType? additional = null, int offset = 0, int limit = 0, StatusFilterType statusFilter = StatusFilterType.All)
		{
			var additionalParams = new [] {
				new QueryStringParameter("offset", offset),
				new QueryStringParameter("limit", limit),
				new QueryStringParameter("status_filter", statusFilter),
				new QueryStringParameter("additional", additional)
			};

			return GetData<FavoriteListResult>("list", 1, additionalParams);
		}
	}
}