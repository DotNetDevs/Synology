using System;
using Synology.Classes;
using System.Collections.Generic;

namespace Synology.DownloadStation
{
	public class ScheduleRequest : SynologyRequest
	{
		public ScheduleRequest(SynologyConnection connection) : base(connection, "DownloadStation/schedule.cgi", "SYNO.DownloadStation.Schedule", 1)
		{
		}

		public ResultData<object> Config()
		{
			var url = GetApiUrl("getconfig");
			return Connection.GetDataFromUrl<object>(url);
		}

		public ResultData<object> SetConfig(bool? enabled, bool? emuleEnabled)
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

			var url = GetApiUrl("setserverconfig", string.Join("&", additionalParams));
			return Connection.GetDataFromUrl<object>(url);
		}
	}
}

