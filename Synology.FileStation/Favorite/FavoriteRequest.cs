using System;
using Synology.Classes;
using Synology.Utilities;
using System.ComponentModel;
using Synology.Attributes;
using Synology.FileStation.Favorite.Results;
using Synology.FileStation.Favorite.Parameters;

namespace Synology.FileStation.Favorite
{
    public class FavoriteRequest : FileStationRequest
    {
        public FavoriteRequest(SynologyApi api) : base(api, "Favorite")
        {
        }

        [RequestMethod("list")]
        public ResultData<FavoriteListResult> List(FavoriteListParameters parameters)
        {
            return GetData<FavoriteListResult>(new SynologyRequestParameters
            {
                Additional = parameters
            });
        }

        [RequestMethod("add")]
        public ResultData Add(FavoriteAddParameters parameters)
        {
            return GetData<FavoriteListResult>(new SynologyRequestParameters
            {
                Additional = parameters
            });
        }

        [RequestMethod("delete")]
        public ResultData Delete(FavoriteDeleteParameters parameters)
        {
            return GetData<FavoriteListResult>(new SynologyRequestParameters
            {
                Additional = parameters
            });
        }

        [RequestMethod("clear_broken")]
        public ResultData ClearBroken()
        {
            return GetData<FavoriteListResult>(new SynologyRequestParameters());
        }

        [RequestMethod("edit")]
        public ResultData Edit(FavoriteEditParameters parameters)
        {
            return GetData<FavoriteListResult>(new SynologyRequestParameters
            {
                Additional = parameters
            });
        }
    }
}