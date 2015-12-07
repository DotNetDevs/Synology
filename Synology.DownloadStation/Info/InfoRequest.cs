using Synology.Classes;
using System.Collections.Generic;
using Synology.Utilities;

namespace Synology.DownloadStation.Info
{
	public class InfoRequest : SynologyRequest
	{
		public InfoRequest(SynologyConnection connection) : base(connection, "DownloadStation/info.cgi", "SYNO.DownloadStation.Info")
		{
		}

		public ResultData<InfoResult> GetInfo()
		{
			return GetData<InfoResult>("getinfo");
		}

		public ResultData<ConfigResult> Config()
		{
			return GetData<ConfigResult>("getconfig", 2);
		}

		public ResultData SetConfig(SetConfigParameters parameters)
		{
			return GetData("setserverconfig", 2, parameters);
		}
	}
}