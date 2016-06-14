using System;
using Synology.Classes;
using Synology.Utilities;
using Synology.Parameters;

namespace Synology.DownloadStation.Info.Parameters
{
	public class SetConfigParameters : RequestParameters
	{
		public int? KbpsTorrentMaxDownload{ get; set; }

		public int? KbpsTorrentMaxUpload{ get; set; }

		public int? KbpsEmuleMaxDownload{ get; set; }

		public int? KbpsEmuleMaxUpload{ get; set; }

		public int? KbpsNzbMaxDownload{ get; set; }

		public int? KbpsHttpMaxDownload{ get; set; }

		public int? KbpsFtpMaxDownload{ get; set; }

		public bool? EmuleEnabled{ get; set; }

		public bool? UnzipEnabled{ get; set; }

		public string DefaultDestination{ get; set; }

		public string EmuleDefaultDestination { get; set; }

		public override QueryStringParameter[] Parameters()
		{
			return new[] {
				new QueryStringParameter("bt_max_download", KbpsTorrentMaxDownload),
				new QueryStringParameter("bt_max_upload", KbpsTorrentMaxUpload),
				new QueryStringParameter("emule_max_download", KbpsEmuleMaxDownload),
				new QueryStringParameter("emule_max_upload", KbpsEmuleMaxUpload),
				new QueryStringParameter("nzb_max_download", KbpsNzbMaxDownload),
				new QueryStringParameter("http_max_download", KbpsHttpMaxDownload),
				new QueryStringParameter("ftp_max_upload", KbpsFtpMaxDownload),
				new QueryStringParameter("emule_enabled", EmuleEnabled),
				new QueryStringParameter("unzip_service_enabled", UnzipEnabled),
				new QueryStringParameter("default_destination", DefaultDestination),
				new QueryStringParameter("emule_default_destination", EmuleDefaultDestination)
			};
		}
	}
}

