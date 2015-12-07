using Synology.Classes;
using Synology.DownloadStation.Info.Results;
using Synology.DownloadStation.Info.Parameters;

namespace Synology.DownloadStation.Info
{
	public class InfoRequest : DownloadStationRequest
	{
		public InfoRequest(SynologyApi api) : base(api, "info.cgi", "Info")
		{
		}

		public ResultData<InfoResult> GetInfo()
		{
			return GetData<InfoResult>(new SynologyRequestParameters { Method = "getinfo" });
		}

		public ResultData<ConfigResult> Config()
		{
			return GetData<ConfigResult>(new SynologyRequestParameters { Method = "getconfig", Version = 2 });
		}

		public ResultData SetConfig(SetConfigParameters parameters)
		{
			return GetData(new SynologyRequestParameters
			{
				Method = "setserverconfig",
				Version = 2,
				Additional = parameters
			});
		}
	}
}