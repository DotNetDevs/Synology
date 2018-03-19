using System;
using System.ComponentModel;

namespace Synology.DownloadStation.Task.Parameters
{
	[Flags]
	public enum TaskDetailsType
	{
		[Description("detail")]
		Detail = 1 << 0,
		[Description("transfer")]
		Transfer = 1 << 1,
		[Description("file")]
		File = 1 << 2,
		[Description("tracker")]
		Tracker = 1 << 3,
		[Description("peer")]
		Peer = 1 << 4
	}
}