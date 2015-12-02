using System;
using Synology.Classes;
using System.Collections.Generic;
using Synology.Utilities;

namespace Synology.DownloadStation
{
	public class ScheduleRequest : SynologyRequest
	{
		public ScheduleRequest(SynologyConnection connection) : base(connection, "DownloadStation/schedule.cgi", "SYNO.DownloadStation.Schedule")
		{
		}

		public ResultData<ScheduleResult> Config()
		{
			var url = GetApiUrl("getconfig", 1);
			return Connection.GetDataFromUrl<ScheduleResult>(url);
		}

		public ResultData SetConfig(bool? enabled, bool? emuleEnabled)
		{
			var additionalParams = new[] {
				new QueryStringParameter("enabled", enabled),
				new QueryStringParameter("emule_enabled", emuleEnabled)
			};

			var url = GetApiUrl("setserverconfig", 1, additionalParams);
			return Connection.GetDataFromUrl(url);
		}
	}
}

