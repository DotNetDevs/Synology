using System;
using Synology.Classes;
using Synology.Utilities;
using System.ComponentModel;
using Synology.FileStation.Favorite.Results;
using Synology.FileStation.Favorite.Parameters;

namespace Synology.FileStation.Favorite
{
	public class FavoriteRequest : FileStationRequest
	{
		public FavoriteRequest(SynologyApi api) : base(api, "file_favorite.cgi", "Favorite")
		{
		}

		public ResultData<FavoriteListResult> List(FavoriteListParameters parameters)
		{
			return GetData<FavoriteListResult>(new SynologyRequestParameters {
				Method = "list",
				Additional = parameters
			});
		}

		public ResultData Add(FavoriteAddParameters parameters)
		{
			return GetData<FavoriteListResult>(new SynologyRequestParameters {
				Method = "add",
				Additional = parameters
			});
		}

		public ResultData Delete(FavoriteDeleteParameters parameters)
		{
			return GetData<FavoriteListResult>(new SynologyRequestParameters {
				Method = "delete",
				Additional = parameters
			});
		}

		public ResultData ClearBroken()
		{
			return GetData<FavoriteListResult>(new SynologyRequestParameters { Method = "clear_broken" });
		}

		public ResultData Edit(FavoriteEditParameters parameters)
		{
			return GetData<FavoriteListResult>(new SynologyRequestParameters {
				Method = "edit",
				Additional = parameters
			});
		}
	}
}