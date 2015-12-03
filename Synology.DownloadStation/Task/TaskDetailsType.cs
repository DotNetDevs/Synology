using System;
using System.ComponentModel;
using System.Collections.Generic;
using Synology.Utilities;

namespace Synology.DownloadStation.Task
{
	[Flags]
	public enum TaskDetailsType
	{
		[Description("")]
		None = 0,
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

	internal static class TaskDetailsTypeHelper
	{
		internal static string GetDescriptions(TaskDetailsType value)
		{
			var values = new List<string>();

			if ((value & TaskDetailsType.Detail) == TaskDetailsType.Detail)
				values.Add(QueryStringParameter.GetEnumDescription(TaskDetailsType.Detail));
			if ((value & TaskDetailsType.Transfer) == TaskDetailsType.Transfer)
				values.Add(QueryStringParameter.GetEnumDescription(TaskDetailsType.Transfer));
			if ((value & TaskDetailsType.File) == TaskDetailsType.File)
				values.Add(QueryStringParameter.GetEnumDescription(TaskDetailsType.File));
			if ((value & TaskDetailsType.Tracker) == TaskDetailsType.Tracker)
				values.Add(QueryStringParameter.GetEnumDescription(TaskDetailsType.Tracker));
			if ((value & TaskDetailsType.Peer) == TaskDetailsType.Peer)
				values.Add(QueryStringParameter.GetEnumDescription(TaskDetailsType.Peer));

			return string.Join(",", values);
		}
	}
}