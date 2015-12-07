using System;
using Newtonsoft.Json;

namespace Synology.FileStation.Favorite.Results
{
	public class FavoriteOwnerResult
	{
		public string User { get; set; }

		public string Group { get; set; }

		public int Uid { get; set; }

		public int Gid { get; set; }
	}
}