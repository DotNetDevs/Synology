using System;
using Synology.Classes;
using Synology.Utilities;
using System.ComponentModel;
using Synology.FileStation.Favorite.Results;
using Synology.FileStation.Favorite.Parameters;

namespace Synology.FileStation.Favorite
{
	public class FavoriteRequest : SynologyRequest
	{
		public FavoriteRequest(SynologyConnection connection) : base(connection, "FileStation/file_favorite.cgi", "SYNO.FileStation.Favorite")
		{
		}

		public ResultData<FavoriteListResult> List(FavoriteDetailsType? additional = null, int offset = 0, int limit = 0, StatusFilterType statusFilter = StatusFilterType.All)
		{
			var additionalParams = new[] {
				new QueryStringParameter("offset", offset),
				new QueryStringParameter("limit", limit),
				new QueryStringParameter("status_filter", statusFilter),
				new QueryStringParameter("additional", additional)
			};

			return GetData<FavoriteListResult>(new SynologyRequestParameters
			{
				Method = "list",
				Additional = additionalParams
			});
		}

		public ResultData Add(string path, string name, int index = -1)
		{
			var additionalParams = new[] {
				new QueryStringParameter("path", path),
				new QueryStringParameter("name", name),
				new QueryStringParameter("index", index)
			};

			return GetData<FavoriteListResult>(new SynologyRequestParameters
			{
				Method = "add",
				Additional = additionalParams
			});
		}

		public ResultData Delete(string path)
		{
			var additionalParams = new[] {
				new QueryStringParameter("path", path)
			};

			return GetData<FavoriteListResult>(new SynologyRequestParameters
			{
				Method = "delete",
				Additional = additionalParams
			});
		}

		public ResultData ClearBroken()
		{
			return GetData<FavoriteListResult>(new SynologyRequestParameters { Method = "clear_broken" });
		}

		public ResultData Edit(string path, string name)
		{
			var additionalParams = new[] {
				new QueryStringParameter("path", path),
				new QueryStringParameter("name", name)
			};

			return GetData<FavoriteListResult>(new SynologyRequestParameters
			{
				Method = "edit",
				Additional = additionalParams
			});
		}
	}
}