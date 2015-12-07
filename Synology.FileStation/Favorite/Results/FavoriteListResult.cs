using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Synology.FileStation.Favorite.Results
{
	public class FavoriteListResult
	{
		public int Total { get; set; }

		public int Offset { get; set; }

		public IEnumerable<FavoriteResult> Favorites { get; set; }
	}
}

