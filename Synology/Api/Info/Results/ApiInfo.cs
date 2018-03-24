using Newtonsoft.Json;
using Synology.Interfaces;

namespace Synology.Api.Info.Results
{
	/// <summary>
	/// 
	/// </summary>
	internal class ApiInfo : IApiInfo
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("path")]
		public string Path { get; internal set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("minVersion")]
		public int MinVersion { get; internal set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("maxVersion")]
		public int MaxVersion { get; internal set; }
	}
}

