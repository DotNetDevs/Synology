using Newtonsoft.Json;

namespace Synology.Api.Auth.Results
{
	/// <summary>
	/// 
	/// </summary>
	internal class AuthResult : IAuthResult
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("sid")]
		public string Sid { get; set; }
	}
}