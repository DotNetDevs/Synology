using System;
using Synology.Classes;
using Synology.Utilities;
using System.ComponentModel.DataAnnotations;

namespace Synology.FileStation.Thumb.Parameters
{
	public class ThumbGetParameters : RequestParameters
	{
		public ThumbGetParameters()
		{
			Size = ThumbSize.Small;
			Rotate = ThumbRotation.Original;
		}

		[Required]
		public string Path { get; set; }

		public ThumbSize Size { get; set; }

		public ThumbRotation Rotate { get; set; }

		public override QueryStringParameter[] Parameters()
		{
			return new[] {
				new QueryStringParameter("path", Path),
				new QueryStringParameter("size", Size),
				new QueryStringParameter("rotate", (int)Rotate)
			};
		}
	}
}

