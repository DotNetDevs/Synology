using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Dynamic;
using System.Configuration;

namespace Synology.FileStation.Favorite
{
	public class FavoriteResult
	{
		public string Path { get; set; }

		public string Name { get; set; }

		public string Status { get; set; }

		public FavoriteAdditionalResult Additional { get; set; }
	}

}

