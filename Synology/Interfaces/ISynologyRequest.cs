namespace Synology.Interfaces
{
	/// <summary>
	/// 
	/// </summary>
	public interface ISynologyRequest
	{
		/// <summary>
		/// 
		/// </summary>
		ISynologyApi Api { get; }
		/// <summary>
		/// 
		/// </summary>
		string CgiPath { get; }
		/// <summary>
		/// 
		/// </summary>
		string ApiName { get; }
	}
}
