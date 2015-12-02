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

		public ResultData SetConfig(int? kbpsTorrentMaxDownload, int? kbpsTorrentMaxUpload, int? kbpsEmuleMaxDownload, int? kbpsEmuleMaxUpload, int? kbpsNzbMaxDownload, int? kbpsHttpMaxDownload, int? kbpsFtpMaxDownload, bool? emuleEnabled, bool? unzipEnabled, string defaultDestination, string emuleDefaultDestination)
		{
			var additionalParams = new[] {
				new QueryStringParameter("bt_max_download", kbpsTorrentMaxDownload),
				new QueryStringParameter("bt_max_upload", kbpsTorrentMaxUpload),
				new QueryStringParameter("emule_max_download", kbpsEmuleMaxDownload),
				new QueryStringParameter("emule_max_upload", kbpsEmuleMaxUpload),
				new QueryStringParameter("nzb_max_download", kbpsNzbMaxDownload),
				new QueryStringParameter("http_max_download", kbpsHttpMaxDownload),
				new QueryStringParameter("ftp_max_upload", kbpsFtpMaxDownload),
				new QueryStringParameter("emule_enabled", emuleEnabled),
				new QueryStringParameter("unzip_service_enabled", unzipEnabled),
				new QueryStringParameter("default_destination", defaultDestination),
				new QueryStringParameter("emule_default_destination", emuleDefaultDestination)
			};
				
			return GetData("setserverconfig", 2, additionalParams);
		}
	}
}