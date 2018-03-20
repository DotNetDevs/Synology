using Synology.Classes;
using Synology.Attributes;
using Synology.FileStation.Favorite.Results;
using Synology.FileStation.Favorite.Parameters;
using Synology.Parameters;

namespace Synology.FileStation.Favorite
{
	[Request("Favorite")]
	internal class FavoriteRequest : FileStationRequest, IFavoriteRequest
	{
        public FavoriteRequest(IFileStationApi api) : base(api)
		{
		}

		[RequestMethod("list")]
		public ResultData<FavoriteListResult> List(FavoriteListParameters parameters)
		{
            return this.GetData<FavoriteListResult>(new SynologyRequestParameters(this)
			{
				Additional = parameters
			});
		}

		[RequestMethod("add")]
		public ResultData Add(FavoriteAddParameters parameters)
		{
            return this.GetData<FavoriteListResult>(new SynologyRequestParameters(this)
			{
				Additional = parameters
			});
		}

		[RequestMethod("delete")]
		public ResultData Delete(FavoriteDeleteParameters parameters)
		{
            return this.GetData<FavoriteListResult>(new SynologyRequestParameters(this)
			{
				Additional = parameters
			});
		}

		[RequestMethod("clear_broken")]
		public ResultData ClearBroken()
		{
            return this.GetData<FavoriteListResult>(new SynologyRequestParameters(this));
		}

		[RequestMethod("edit")]
		public ResultData Edit(FavoriteEditParameters parameters)
		{
            return this.GetData<FavoriteListResult>(new SynologyRequestParameters(this)
			{
				Additional = parameters
			});
		}
	}
}