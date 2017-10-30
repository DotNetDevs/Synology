using Synology.Attributes;
using Synology.Classes;
using Synology.DownloadStation.Schedule.Parameters;
using Synology.DownloadStation.Schedule.Results;
using Synology.Interfaces;
using Synology.Parameters;

namespace Synology.DownloadStation.Schedule
{
	[Request("Schedule")]
    internal class ScheduleRequest : DownloadStationRequest, IScheduleRequest
	{
		public ScheduleRequest(IDownloadStationApi api) : base(api)
		{
		}

		[RequestMethod("getconfig")]
		public ResultData<ScheduleResult> Config()
		{
			return GetData<ScheduleResult>(new SynologyRequestParameters(this));
		}

		[RequestMethod("setserverconfig")]
		public ResultData SetConfig(SetConfigParameters parameters)
		{
			return GetData(new SynologyRequestParameters(this)
			{
				Additional = parameters
			});
		}
	}
}

