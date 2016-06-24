using System;
using Newtonsoft.Json;

namespace Synology.FileStation.Favorite.Results
{
	public class FavoritePermAclResult
	{
		public bool Append { get; set; }

		public bool Del { get; set; }

		public bool Exec { get; set; }

		public bool Read { get; set; }

		public bool Write { get; set; }
	}
}