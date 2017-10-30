using Synology.Attributes;
using Synology.Classes;
using Synology.DownloadStation.Info.Results;
using Synology.DownloadStation.Info.Parameters;
using Synology.Parameters;

namespace Synology.DownloadStation.Info
{
	[Request("Info")]
    class InfoRequest : DownloadStationRequest, IInfoRequest
	{
		public InfoRequest(IDownloadStationApi api) : base(api)
		{
		}

		[RequestMethod("getinfo")]
		public ResultData<InfoResult> GetInfo()
		{
			return GetData<InfoResult>(new SynologyRequestParameters(this));
		}

		[RequestMethod("getconfig")]
		public ResultData<ConfigResult> Config()
		{
			return GetData<ConfigResult>(new SynologyRequestParameters(this) { Version = 2 });
		}

		[RequestMethod("setserverconfig")]
		public ResultData SetConfig(SetConfigParameters parameters)
		{
			return GetData(new SynologyRequestParameters(this)
			{
				Version = 2,
				Additional = parameters
			});
		}
	}
}