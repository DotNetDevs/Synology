namespace Synology.Interfaces
{
	/// <summary>
	/// 
	/// </summary>
	public interface ISynologyConnectionSettings
	{
		/// <summary>
		/// 
		/// </summary>
		string WebApiUrl { get; }
		/// <summary>
		/// 
		/// </summary>
		string Username { get; set; }
		/// <summary>
		/// 
		/// </summary>
		string Password { get; set; }
		/// <summary>
		/// 
		/// </summary>
		string BaseHost { get; set; }
		/// <summary>
		/// 
		/// </summary>
		bool Ssl { get; set; }
		/// <summary>
		/// 
		/// </summary>
		int Port { get; set; }
		/// <summary>
		/// 
		/// </summary>
		int SslPort { get; set; }
	}
}
