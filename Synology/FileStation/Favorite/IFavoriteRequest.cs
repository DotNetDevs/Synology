using Synology.Classes;
using Synology.FileStation.Favorite.Parameters;
using Synology.FileStation.Favorite.Results;
using Synology.Interfaces;

namespace Synology.FileStation.Favorite
{
    /// <summary>
    /// Favorite request.
    /// </summary>
    public interface IFavoriteRequest : ISynologyRequest
    {
        /// <summary>
        /// List the specified parameters.
        /// </summary>
        /// <returns>The list.</returns>
        /// <param name="parameters">Parameters.</param>
        ResultData<FavoriteListResult> List(FavoriteListParameters parameters);

        /// <summary>
        /// Add the specified parameters.
        /// </summary>
        /// <returns>The add.</returns>
        /// <param name="parameters">Parameters.</param>
        ResultData Add(FavoriteAddParameters parameters);

        /// <summary>
        /// Delete the specified parameters.
        /// </summary>
        /// <returns>The delete.</returns>
        /// <param name="parameters">Parameters.</param>
        ResultData Delete(FavoriteDeleteParameters parameters);

        /// <summary>
        /// Clears the broken.
        /// </summary>
        /// <returns>The broken.</returns>
        ResultData ClearBroken();

        /// <summary>
        /// Edit the specified parameters.
        /// </summary>
        /// <returns>The edit.</returns>
        /// <param name="parameters">Parameters.</param>
        ResultData Edit(FavoriteEditParameters parameters);
    }
}
