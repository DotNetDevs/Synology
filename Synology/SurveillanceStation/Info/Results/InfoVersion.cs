using Newtonsoft.Json;

namespace Synology.SurveillanceStation.Info.Results
{
	/// <summary>
	/// 
	/// </summary>
	public class InfoVersion
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("major")]
		public int Major { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("minor")]
		public int Minor { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("build")]
		public int Build { get; set; }
	}
}