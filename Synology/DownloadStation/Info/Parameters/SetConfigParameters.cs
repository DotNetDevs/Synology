using Synology.Utilities;
using Synology.Parameters;

namespace Synology.DownloadStation.Info.Parameters
{
	/// <inheritdoc />
	/// <summary>
	/// 
	/// </summary>
	public class SetConfigParameters : RequestParameters
	{
		/// <summary>
		/// 
		/// </summary>
		public int? KbpsTorrentMaxDownload { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public int? KbpsTorrentMaxUpload { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public int? KbpsEmuleMaxDownload { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public int? KbpsEmuleMaxUpload { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public int? KbpsNzbMaxDownload { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public int? KbpsHttpMaxDownload { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public int? KbpsFtpMaxDownload { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public bool? EmuleEnabled { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public bool? UnzipEnabled { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public string DefaultDestination { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public string EmuleDefaultDestination { get; set; }

		/// <inheritdoc />
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
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

