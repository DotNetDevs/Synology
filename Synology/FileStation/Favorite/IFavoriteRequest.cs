using Synology.Classes;
using Synology.FileStation.Favorite.Parameters;
using Synology.FileStation.Favorite.Results;
using Synology.Interfaces;

namespace Synology.FileStation.Favorite
{
    public interface IFavoriteRequest : ISynologyRequest
    {
        ResultData<FavoriteListResult> List(FavoriteListParameters parameters);

        ResultData Add(FavoriteAddParameters parameters);

        ResultData Delete(FavoriteDeleteParameters parameters);

        ResultData ClearBroken();

        ResultData Edit(FavoriteEditParameters parameters);
    }
}
