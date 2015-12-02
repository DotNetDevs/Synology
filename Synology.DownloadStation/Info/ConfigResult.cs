using System;
using Newtonsoft.Json;

namespace Synology.DownloadStation.Info
{
	public class ConfigResult
	{
		[JsonProperty("bt_max_download")]
		public int TorrentMaxDownload { get; set; }

		[JsonProperty("bt_max_upload")]
		public int TorrentMaxUpload { get; set; }

		[JsonProperty("default_destination")]
		public string DefaultDestination { get; set; }

		[JsonProperty("emule_default_destination")]
		public string EmuleDefaultDestination { get; set; }

		[JsonProperty("emule_enabled")]
		public bool EmuleEnabled { get; set; }

		[JsonProperty("emule_max_download")]
		public int EmuleMaxDownload { get; set; }

		[JsonProperty("emule_max_upload")]
		public int EmuleMaxUpload { get; set; }

		[JsonProperty("ftp_max_download")]
		public int FtpMaxDownload { get; set; }

		[JsonProperty("http_max_download")]
		public int HttpMaxDownload { get; set; }

		[JsonProperty("nzb_max_download")]
		public int NzbMaxDownload { get; set; }

		[JsonProperty("unzip_service_enabled")]
		public bool UnzipServiceEnabled { get; set; }

		[JsonProperty("xunlei_enabled")]
		public bool XunleiEnabled { get; set; }
	}
}

