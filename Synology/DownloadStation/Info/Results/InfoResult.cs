using Newtonsoft.Json;

namespace Synology.DownloadStation.Info.Results
{
	/// <summary>
	/// 
	/// </summary>
	public class InfoResult
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("is_manager")]
		public bool IsManager { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("version")]
		public int Version { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("version_string")]
		public string VersionString { get; set; }
	}
}