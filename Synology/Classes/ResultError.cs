using Newtonsoft.Json;

namespace Synology.Classes
{
	/// <summary>
	/// 
	/// </summary>
	public sealed class ResultError
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("code")]
		public int Code { get; set; }
	}
}