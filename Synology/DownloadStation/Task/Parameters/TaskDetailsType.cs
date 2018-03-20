using System;
using System.ComponentModel;

namespace Synology.DownloadStation.Task.Parameters
{
    /// <summary>
    /// Task details type.
    /// </summary>
	[Flags]
	public enum TaskDetailsType
	{
        /// <summary>
        /// The detail.
        /// </summary>
		[Description("detail")]
		Detail = 1 << 0,
		/// <summary>
        /// The transfer.
        /// </summary>
        [Description("transfer")]
		Transfer = 1 << 1,
		/// <summary>
        /// The file.
        /// </summary>
        [Description("file")]
		File = 1 << 2,
		/// <summary>
        /// The tracker.
        /// </summary>
        [Description("tracker")]
		Tracker = 1 << 3,
		/// <summary>
        /// The peer.
        /// </summary>
        [Description("peer")]
		Peer = 1 << 4
	}
}