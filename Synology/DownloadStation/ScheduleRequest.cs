using System;
using Synology.Classes;
using System.Collections.Generic;

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
			var additionalParams = new List<string>();

			if (enabled.HasValue)
			{
				additionalParams.Add(string.Format("enabled={0}", enabled));
			}

			if (emuleEnabled.HasValue)
			{
				additionalParams.Add(string.Format("emule_enabled={0}", emuleEnabled));
			}

			var url = GetApiUrl("setserverconfig", 1, string.Join("&", additionalParams));
			return Connection.GetDataFromUrl<object>(url);
		}
	}
}

