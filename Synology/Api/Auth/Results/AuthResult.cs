using Newtonsoft.Json;

namespace Synology.Api.Auth.Results
{
	/// <summary>
	/// 
	/// </summary>
	public class AuthResult
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("sid")]
		public string Sid { get; set; }
	}
}