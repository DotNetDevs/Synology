using Synology.Classes;
using Synology.DownloadStation.Schedule.Parameters;
using Synology.DownloadStation.Schedule.Results;

namespace Synology.DownloadStation.Schedule
{
	public class ScheduleRequest : SynologyRequest
	{
		public ScheduleRequest(SynologyConnection connection) : base(connection, "DownloadStation/schedule.cgi", "SYNO.DownloadStation.Schedule")
		{
		}

		public ResultData<ScheduleResult> Config()
		{
			return GetData<ScheduleResult>(new SynologyRequestParameters { Method = "getconfig" });
		}

		public ResultData SetConfig(SetConfigParameters parameters)
		{
			return GetData(new SynologyRequestParameters
			{
				Method = "setserverconfig",
				Additional = parameters
			});
		}
	}
}

