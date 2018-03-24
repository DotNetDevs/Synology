using System.ComponentModel;

namespace Synology.FileStation.Favorite.Parameters
{
    /// <summary>
    /// Status filter type.
    /// </summary>
	public enum StatusFilterType
	{
        /// <summary>
        /// The valid.
        /// </summary>
		[Description("valid")]
		Valid,

        /// <summary>
        /// The broken.
        /// </summary>
		[Description("broken")]
		Broken,

        /// <summary>
        /// All.
        /// </summary>
		[Description("all")]
		All
	}
}