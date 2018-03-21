using System;
using System.Threading.Tasks;
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
        [Obsolete("It uses Result, migrate to Async methods")]
        ResultData<IFavoriteListResult> List(FavoriteListParameters parameters);

        /// <summary>
        /// Add the specified parameters.
        /// </summary>
        /// <returns>The add.</returns>
        /// <param name="parameters">Parameters.</param>
        [Obsolete("It uses Result, migrate to Async methods")]
        ResultData Add(FavoriteAddParameters parameters);

        /// <summary>
        /// Delete the specified parameters.
        /// </summary>
        /// <returns>The delete.</returns>
        /// <param name="parameters">Parameters.</param>
        [Obsolete("It uses Result, migrate to Async methods")]
        ResultData Delete(FavoriteDeleteParameters parameters);

        /// <summary>
        /// Clears the broken.
        /// </summary>
        /// <returns>The broken.</returns>
        [Obsolete("It uses Result, migrate to Async methods")]
        ResultData ClearBroken();

        /// <summary>
        /// Edit the specified parameters.
        /// </summary>
        /// <returns>The edit.</returns>
        /// <param name="parameters">Parameters.</param>
        [Obsolete("It uses Result, migrate to Async methods")]
        ResultData Edit(FavoriteEditParameters parameters);

        /// <summary>
        /// List the specified parameters.
        /// </summary>
        /// <returns>The list.</returns>
        /// <param name="parameters">Parameters.</param>
        Task<ResultData<IFavoriteListResult>> ListAsync(FavoriteListParameters parameters);

        /// <summary>
        /// Add the specified parameters.
        /// </summary>
        /// <returns>The add.</returns>
        /// <param name="parameters">Parameters.</param>
        Task<ResultData> AddAsync(FavoriteAddParameters parameters);

        /// <summary>
        /// Delete the specified parameters.
        /// </summary>
        /// <returns>The delete.</returns>
        /// <param name="parameters">Parameters.</param>
        Task<ResultData> DeleteAsync(FavoriteDeleteParameters parameters);

        /// <summary>
        /// Clears the broken.
        /// </summary>
        /// <returns>The broken.</returns>
        Task<ResultData> ClearBrokenAsync();

        /// <summary>
        /// Edit the specified parameters.
        /// </summary>
        /// <returns>The edit.</returns>
        /// <param name="parameters">Parameters.</param>
        Task<ResultData> EditAsync(FavoriteEditParameters parameters);
    }
}
