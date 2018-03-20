using System;
using System.Threading.Tasks;
using Synology.Attributes;
using Synology.Classes;
using Synology.DownloadStation.Schedule.Parameters;
using Synology.DownloadStation.Schedule.Results;
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
        [Obsolete("It uses Result, migrate to Async methods")]
		public ResultData<ScheduleResult> Config()
		{
            return this.GetData<ScheduleResult>(new SynologyRequestParameters(this));
		}

		[RequestMethod("setserverconfig")]
        [Obsolete("It uses Result, migrate to Async methods")]
		public ResultData SetConfig(SetConfigParameters parameters)
		{
            return this.GetData(new SynologyRequestParameters(this)
			{
				Additional = parameters
			});
		}

        [RequestMethod("getconfig")]
        public async Task<ResultData<ScheduleResult>> ConfigAsync()
        {
            return await this.GetDataAsync<ScheduleResult>(new SynologyRequestParameters(this));
        }

        [RequestMethod("setserverconfig")]
        public async Task<ResultData> SetConfigAsync(SetConfigParameters parameters)
        {
            return await this.GetDataAsync(new SynologyRequestParameters(this)
            {
                Additional = parameters
            });
        }
	}
}

