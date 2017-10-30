using System;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using Synology.Interfaces;

namespace Synology
{
	/// <inheritdoc />
	/// <summary>
	/// 
	/// </summary>
	internal sealed class SynologyConnection : ISynologyConnection
	{
		/// <inheritdoc />
		/// <summary>
		/// </summary>
		public ILogger Logger { get; }

		/// <inheritdoc />
		/// <summary>
		/// </summary>
		public ISynologyConnectionSettings Settings { get; }

		/// <inheritdoc />
		/// <summary>
		/// </summary>
		public HttpClient Client { get; }

		/// <inheritdoc />
		/// <summary>
		/// </summary>
		public IServiceProvider ServiceProvider { get; }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="settings"></param>
		/// <param name="loggerFactory"></param>
		/// <param name="serviceProvider"></param>
		public SynologyConnection(ISynologyConnectionSettings settings, ILoggerFactory loggerFactory, IServiceProvider serviceProvider)
		{
			Settings = settings;
			ServiceProvider = serviceProvider;
			Logger = loggerFactory.CreateLogger<SynologyConnection>();

			Logger.LogDebug($"Creating new connection to {Settings.BaseHost} with{(Settings.Ssl ? "" : "out")} SSL to port {Settings.Port}");

			Client = new HttpClient
			{
				BaseAddress = new Uri(Settings.WebApiUrl),
				DefaultRequestHeaders = {
					ExpectContinue = false
				}
			};
		}

		/// <inheritdoc />
		/// <summary>
		/// </summary>
		public void Dispose()
		{
			Logger.LogDebug("Closing connection");
			Client?.Dispose();
		}
	}
}