using System;
using System.ComponentModel;

namespace Synology.FileStation.Favorite
{
	public enum StatusFilterType
	{
		[Description("valid")]
		Valid,
		[Description("broken")]
		Broken,
		[Description("all")]
		All
	}
}