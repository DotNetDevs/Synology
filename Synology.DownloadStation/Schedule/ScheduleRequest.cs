using System;
using Synology.Classes;
using Synology.Utilities;

namespace Synology.DownloadStation.Schedule
{
	public class ScheduleRequest : SynologyRequest
	{
		public ScheduleRequest(SynologyConnection connection) : base(connection, "DownloadStation/schedule.cgi", "SYNO.DownloadStation.Schedule")
		{
		}

		public ResultData<ScheduleResult> Config()
		{
			return GetData<ScheduleResult>("getconfig", 1);
		}

		public ResultData SetConfig(SetConfigParameters parameters)
		{
			return GetData("setserverconfig", 1, parameters);
		}
	}
}

