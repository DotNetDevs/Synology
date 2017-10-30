using System;
using Synology.Classes;
using Synology.Utilities;
using System.ComponentModel.DataAnnotations;
using Synology.Parameters;

namespace Synology.FileStation.Favorite.Parameters
{
	public class FavoriteEditParameters : RequestParameters
	{
		[Required]
		public string Path { get; set; }

		[Required]
		public string Name { get; set; }

		public override QueryStringParameter[] Parameters()
		{
			return new[] {
				new QueryStringParameter("path", Path),
				new QueryStringParameter("name", Name)
			};
		}
	}
}

