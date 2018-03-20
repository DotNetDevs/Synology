using Synology.Utilities;
using Synology.Parameters;

namespace Synology.FileStation.Favorite.Parameters
{
    /// <summary>
    /// Favorite list parameters.
    /// </summary>
	public class FavoriteListParameters : RequestParameters
	{
        /// <summary>
        /// Parameters this instance.
        /// </summary>
        /// <returns>The parameters.</returns>
		public override QueryStringParameter[] Parameters()
		{
			return new[] {
				new QueryStringParameter("offset", Offset),
				new QueryStringParameter("limit", Limit),
				new QueryStringParameter("status_filter", StatusFilter),
				new QueryStringParameter("additional", Additional)
			};
		}

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Synology.FileStation.Favorite.Parameters.FavoriteListParameters"/> class.
        /// </summary>
		public FavoriteListParameters()
		{
			Additional = null;
			Offset = 0;
			Limit = 0;
			StatusFilter = StatusFilterType.All;
		}

        /// <summary>
        /// Gets or sets the additional.
        /// </summary>
        /// <value>The additional.</value>
		public FavoriteDetailsType? Additional { get; set; }

        /// <summary>
        /// Gets or sets the offset.
        /// </summary>
        /// <value>The offset.</value>
		public int Offset { get; set; }

        /// <summary>
        /// Gets or sets the limit.
        /// </summary>
        /// <value>The limit.</value>
		public int Limit { get; set; }

        /// <summary>
        /// Gets or sets the status filter.
        /// </summary>
        /// <value>The status filter.</value>
		public StatusFilterType StatusFilter { get; set; }
	}
}

