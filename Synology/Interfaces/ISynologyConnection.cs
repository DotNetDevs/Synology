using System;
using System.Net.Http;
using Microsoft.Extensions.Logging;

namespace Synology.Interfaces
{
	/// <inheritdoc />
	/// <summary>
	/// </summary>
	public interface ISynologyConnection : IDisposable
	{
		/// <summary>
		/// 
		/// </summary>
		ILogger Logger { get; }

		/// <summary>
		/// 
		/// </summary>
		ISynologyConnectionSettings Settings { get; }

		/// <summary>
		/// 
		/// </summary>
		HttpClient Client { get; }

		/// <summary>
		/// 
		/// </summary>
		IServiceProvider ServiceProvider { get; }
	}
}
