using System;
using Synology.Classes;
using System.Runtime.InteropServices;
using System.Text;
using System.Collections.Generic;

namespace Synology.DownloadStation
{
	public class InfoRequest : SynologyRequest
	{
		public InfoRequest(SynologyConnection connection) : base(connection, "DownloadStation/info.cgi", "SYNO.DownloadStation.Info")
		{
		}

		public ResultData<InfoResult> Info()
		{
			var url = GetApiUrl("getinfo");
			return Connection.GetDataFromUrl<InfoResult>(url);
		}

		public ResultData<ConfigResult> Config()
		{
			var url = GetApiUrl("getconfig", 2);
			return Connection.GetDataFromUrl<ConfigResult>(url);
		}

		public ResultData SetConfig(int? kbpsTorrentMaxDownload, int? kbpsTorrentMaxUpload, int? kbpsEmuleMaxDownload, int? kbpsEmuleMaxUpload, int? kbpsNzbMaxDownload, int? kbpsHttpMaxDownload, int? kbpsFtpMaxDownload, bool? emuleEnabled, bool? unzipEnabled, string defaultDestination, string emuleDefaultDestination)
		{
			var additionalParams = new List<string>();

			if (kbpsTorrentMaxDownload.HasValue)
			{
				additionalParams.Add(string.Format("bt_max_download={0}", kbpsTorrentMaxDownload));
			}

			if (kbpsTorrentMaxUpload.HasValue)
			{
				additionalParams.Add(string.Format("bt_max_upload={0}", kbpsTorrentMaxUpload));
			}

			if (kbpsEmuleMaxDownload.HasValue)
			{
				additionalParams.Add(string.Format("emule_max_download={0}", kbpsEmuleMaxDownload));
			}

			if (kbpsEmuleMaxUpload.HasValue)
			{
				additionalParams.Add(string.Format("emule_max_upload={0}", kbpsEmuleMaxUpload));
			}

			if (kbpsNzbMaxDownload.HasValue)
			{
				additionalParams.Add(string.Format("nzb_max_download={0}", kbpsNzbMaxDownload));
			}

			if (kbpsHttpMaxDownload.HasValue)
			{
				additionalParams.Add(string.Format("http_max_download={0}", kbpsHttpMaxDownload));
			}

			if (kbpsFtpMaxDownload.HasValue)
			{
				additionalParams.Add(string.Format("ftp_max_upload={0}", kbpsFtpMaxDownload));
			}

			if (emuleEnabled.HasValue)
			{
				additionalParams.Add(string.Format("emule_enabled={0}", emuleEnabled));
			}

			if (unzipEnabled.HasValue)
			{
				additionalParams.Add(string.Format("unzip_service_enabled={0}", unzipEnabled));
			}

			if (!string.IsNullOrWhiteSpace(defaultDestination))
			{
				additionalParams.Add(string.Format("default_destination={0}", defaultDestination));
			}

			if (!string.IsNullOrWhiteSpace(emuleDefaultDestination))
			{
				additionalParams.Add(string.Format("emule_default_destination={0}", emuleDefaultDestination));
			}

			var url = GetApiUrl("setserverconfig", 2, string.Join("&", additionalParams));
			return Connection.GetDataFromUrl<object>(url);
		}
	}
}

