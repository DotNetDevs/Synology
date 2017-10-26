using Newtonsoft.Json;

namespace Synology.Classes
{
	public class ResultData
	{
        [JsonProperty("success")]
		public bool Success { get; set; }

        [JsonProperty("error")]
		public ResultError Error { get; set; }
	}

	public sealed class ResultData<T> : ResultData
	{
        [JsonProperty("data")]
		public T Data { get; set; }
	}
}