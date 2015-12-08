using System;
using Synology.Classes;
using Synology.Utilities;
using System.ComponentModel.DataAnnotations;

namespace Synology.FileStation.Favorite.Parameters
{
	public class FavoriteDeleteParameters : RequestParameters
	{
		[Required]
		public string Path { get; set; }

		public override QueryStringParameter[] Parameters()
		{
			return new[] {
				new QueryStringParameter("path", Path)
			};
		}
	}
}

