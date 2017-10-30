using Newtonsoft.Json;

namespace Synology.DownloadStation.Info.Results
{
	/// <summary>
	/// 
	/// </summary>
	public class ConfigResult
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("bt_max_download")]
		public int TorrentMaxDownload { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("bt_max_upload")]
		public int TorrentMaxUpload { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("default_destination")]
		public string DefaultDestination { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("emule_default_destination")]
		public string EmuleDefaultDestination { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("emule_enabled")]
		public bool EmuleEnabled { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("emule_max_download")]
		public int EmuleMaxDownload { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("emule_max_upload")]
		public int EmuleMaxUpload { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("ftp_max_download")]
		public int FtpMaxDownload { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("http_max_download")]
		public int HttpMaxDownload { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("nzb_max_download")]
		public int NzbMaxDownload { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("unzip_service_enabled")]
		public bool UnzipServiceEnabled { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("xunlei_enabled")]
		public bool XunleiEnabled { get; set; }
	}
}

