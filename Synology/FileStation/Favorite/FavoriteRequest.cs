using Synology.Classes;
using Synology.Attributes;
using Synology.FileStation.Favorite.Results;
using Synology.FileStation.Favorite.Parameters;
using Synology.Parameters;
using System;
using System.Threading.Tasks;

namespace Synology.FileStation.Favorite
{
    [Request("Favorite")]
    internal class FavoriteRequest : FileStationRequest, IFavoriteRequest
    {
        public FavoriteRequest(IFileStationApi api) : base(api)
        {
        }

        [RequestMethod("list")]
        public async Task<ResultData<IFavoriteListResult>> ListAsync(FavoriteListParameters parameters)
        {
            return ResultData<IFavoriteListResult>.From(await this.GetDataAsync<FavoriteListResult>(new SynologyRequestParameters(this)
            {
                Additional = parameters
            }));
        }

        [RequestMethod("add")]
        public async Task<ResultData> AddAsync(FavoriteAddParameters parameters)
        {
            return await this.GetDataAsync<FavoriteListResult>(new SynologyRequestParameters(this)
            {
                Additional = parameters
            });
        }

        [RequestMethod("delete")]
        public async Task<ResultData> DeleteAsync(FavoriteDeleteParameters parameters)
        {
            return await this.GetDataAsync<FavoriteListResult>(new SynologyRequestParameters(this)
            {
                Additional = parameters
            });
        }

        [RequestMethod("clear_broken")]
        public async Task<ResultData> ClearBrokenAsync()
        {
            return await this.GetDataAsync<FavoriteListResult>(new SynologyRequestParameters(this));
        }

        [RequestMethod("edit")]
        public async Task<ResultData> EditAsync(FavoriteEditParameters parameters)
        {
            return await this.GetDataAsync<FavoriteListResult>(new SynologyRequestParameters(this)
            {
                Additional = parameters
            });
        }
    }
}