using System.ComponentModel;

namespace Synology.FileStation.Favorite.Parameters
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