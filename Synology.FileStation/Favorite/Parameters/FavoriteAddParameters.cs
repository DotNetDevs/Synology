using System;
using Synology.Classes;
using Synology.Utilities;
using System.ComponentModel.DataAnnotations;

namespace Synology.FileStation.Favorite.Parameters
{
	public class FavoriteAddParameters : RequestParameters
	{
		public FavoriteAddParameters()
		{
			Index = -1;
		}

		[Required]
		public string Path { get; set; }

		[Required]
		public string Name { get; set; }

		public int Index { get; set; }

		public override QueryStringParameter[] Parameters()
		{
			return new[] {
				new QueryStringParameter("path", Path),
				new QueryStringParameter("name", Name),
				new QueryStringParameter("index", Index)
			};
		}
	}
}

