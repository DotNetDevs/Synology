using Newtonsoft.Json;

namespace Synology.Api.Auth.Results
{
	public class AuthResult
	{
        [JsonProperty("sid")]
		public string Sid { get; set; }
	}
}