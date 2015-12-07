using System;
using System.ComponentModel;

namespace Synology.FileStation.FileShare.Parameters
{
	[Flags]
	public enum FileShareDetailsType
	{
		[Description("real_path")]
		RealPath = 1 << 0,
		[Description("size")]
		Size = 1 << 1,
		[Description("owner")]
		Owner = 1 << 2,
		[Description("time")]
		Time = 1 << 3,
		[Description("perm")]
		Perm = 1 << 4,
		[Description("mount_point_type")]
		MountPointType = 1 << 5,
		[Description("volume_status")]
		VolumeStatus = 1 << 6
	}
}