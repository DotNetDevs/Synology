using System;
using System.ComponentModel;

namespace Synology.FileStation.Thumb.Parameters
{
	public enum ThumbSize
	{
		[Description("small")]
		Small,
		[Description("medium")]
		Medium,
		[Description("large")]
		Large,
		[Description("original")]
		Original
	}
}

