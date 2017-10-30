using Newtonsoft.Json;

namespace Synology.Classes
{
	/// <summary>
	/// 
	/// </summary>
	public class ResultData
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("success")]
		public bool Success { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("error")]
		public ResultError Error { get; set; }
	}

	/// <inheritdoc />
	/// <summary>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public sealed class ResultData<T> : ResultData
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("data")]
		public T Data { get; set; }
	}
}