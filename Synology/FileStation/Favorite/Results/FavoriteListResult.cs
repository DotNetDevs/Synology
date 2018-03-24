using Newtonsoft.Json;
using System.Collections.Generic;

namespace Synology.FileStation.Favorite.Results
{
    /// <summary>
    /// Favorite list result.
    /// </summary>
	internal class FavoriteListResult : IFavoriteListResult
	{
        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        /// <value>The total.</value>
        [JsonProperty("total")]
		public int Total { get; }

        /// <summary>
        /// Gets or sets the offset.
        /// </summary>
        /// <value>The offset.</value>
        [JsonProperty("offset")]
		public int Offset { get; }

        /// <summary>
        /// Gets or sets the favorites.
        /// </summary>
        /// <value>The favorites.</value>
        [JsonProperty("favorites")]
		public IEnumerable<IFavoriteResult> Favorites { get; }
	}
}

