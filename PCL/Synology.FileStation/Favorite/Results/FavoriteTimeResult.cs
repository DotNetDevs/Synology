using System;
using Newtonsoft.Json;

namespace Synology.FileStation.Favorite.Results
{
	public class FavoriteTimeResult
	{
		public int Atime { get; set; }

		public int Mtime { get; set; }

		public int Ctime { get; set; }

		public int CrTime { get; set; }
	}
}