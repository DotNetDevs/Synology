using System;
using System.ComponentModel;

namespace Synology.FileStation.FileShare.Parameters
{
    /// <summary>
    /// File share details type.
    /// </summary>
	[Flags]
	public enum FileShareDetailsType
	{
        /// <summary>
        /// The real path.
        /// </summary>
		[Description("real_path")]
		RealPath = 1 << 0,

        /// <summary>
        /// The size.
        /// </summary>
		[Description("size")]
		Size = 1 << 1,

        /// <summary>
        /// The owner.
        /// </summary>
		[Description("owner")]
		Owner = 1 << 2,

        /// <summary>
        /// The time.
        /// </summary>
		[Description("time")]
		Time = 1 << 3,

        /// <summary>
        /// The perm.
        /// </summary>
		[Description("perm")]
		Perm = 1 << 4,

        /// <summary>
        /// The type of the mount point.
        /// </summary>
		[Description("mount_point_type")]
		MountPointType = 1 << 5,

        /// <summary>
        /// The volume status.
        /// </summary>
		[Description("volume_status")]
		VolumeStatus = 1 << 6
	}
}