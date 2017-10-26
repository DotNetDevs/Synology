using Newtonsoft.Json;

namespace Synology.Classes
{
	public sealed class ResultError
	{
        [JsonProperty("code")]
		public int Code { get; set; }
	}
}