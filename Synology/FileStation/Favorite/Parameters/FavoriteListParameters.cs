using Synology.Utilities;
using Synology.Parameters;

namespace Synology.FileStation.Favorite.Parameters
{
	public class FavoriteListParameters : RequestParameters
	{
		public override QueryStringParameter[] Parameters()
		{
			return new[] {
				new QueryStringParameter("offset", Offset),
				new QueryStringParameter("limit", Limit),
				new QueryStringParameter("status_filter", StatusFilter),
				new QueryStringParameter("additional", Additional)
			};
		}

		public FavoriteListParameters()
		{
			Additional = null;
			Offset = 0;
			Limit = 0;
			StatusFilter = StatusFilterType.All;
		}

		public FavoriteDetailsType? Additional { get; set; }

		public int Offset { get; set; }

		public int Limit { get; set; }

		public StatusFilterType StatusFilter { get; set; }
	}
}

