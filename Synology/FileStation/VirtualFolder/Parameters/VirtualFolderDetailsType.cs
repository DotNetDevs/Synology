using System;
using System.ComponentModel;

namespace Synology.FileStation.VirtualFolder.Parameters
{
	[Flags]
	public enum VirtualFolderDetailsType
	{
		[Description("real_path")]
		RealPath = 1 << 0,
		[Description("owner")]
		Owner = 1 << 1,
		[Description("time")]
		Time = 1 << 2,
		[Description("perm")]
		Perm = 1 << 3,
		[Description("mount_point_type")]
		MountPointType = 1 << 4,
		[Description("volume_status")]
		VolumeStatus = 1 << 5
	}
}