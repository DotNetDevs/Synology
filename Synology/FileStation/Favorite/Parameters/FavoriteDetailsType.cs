using System;
using System.ComponentModel;

namespace Synology.FileStation.Favorite.Parameters
{
    /// <summary>
    /// Favorite details type.
    /// </summary>
	[Flags]
	public enum FavoriteDetailsType
	{
        /// <summary>
        /// The real path.
        /// </summary>
		[Description("real_path")]
		RealPath = 1 << 0,

        /// <summary>
        /// The owner.
        /// </summary>
		[Description("owner")]
		Owner = 1 << 1,

        /// <summary>
        /// The time.
        /// </summary>
		[Description("time")]
		Time = 1 << 2,

        /// <summary>
        /// The perm.
        /// </summary>
		[Description("perm")]
		Perm = 1 << 3,

        /// <summary>
        /// The type of the mount point.
        /// </summary>
		[Description("mount_point_type")]
		MountPointType = 1 << 4
	}
}