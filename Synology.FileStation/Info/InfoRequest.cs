using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Synology.Classes;
using Synology.FileStation.Info.Results;

namespace Synology.FileStation.Info
{
	public class InfoRequest : FileStationRequest
	{
		public InfoRequest(SynologyApi api) : base(api, "info.cgi", "Info")
		{
		}

		public ResultData<InfoResult> GetInfo()
		{
			return GetData<InfoResult>(new SynologyRequestParameters { Method = "getinfo" });
		}
	}
}
