using System.Collections.Generic;

namespace Synology.FileStation.Favorite.Results
{
    /// <summary>
    /// Favorite list result.
    /// </summary>
    public interface IFavoriteListResult
    {
        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        /// <value>The total.</value>
        int Total { get; }
        /// <summary>
        /// Gets or sets the offset.
        /// </summary>
        /// <value>The offset.</value>
        int Offset { get; }
        /// <summary>
        /// Gets or sets the favorites.
        /// </summary>
        /// <value>The favorites.</value>
        IEnumerable<IFavoriteResult> Favorites { get; }
    }
}