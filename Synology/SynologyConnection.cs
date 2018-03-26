using System;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using Synology.Interfaces;
using Synology.Utilities;

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
        public HttpClientHandler ClientHandler { get; }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        public IServiceProvider ServiceProvider { get; }

        public SidContainer SidContainer { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Synology.SynologyConnection"/> class.
        /// </summary>
        /// <param name="settings">Settings.</param>
        /// <param name="sidContainer">Sid container.</param>
        /// <param name="loggerFactory">Logger factory.</param>
        /// <param name="serviceProvider">Service provider.</param>
        /// <param name="client">Client.</param>
        /// <param name="clientHandler">Client.</param>
        public SynologyConnection(ISynologyConnectionSettings settings, SidContainer sidContainer, ILoggerFactory loggerFactory, IServiceProvider serviceProvider, HttpClient client, HttpClientHandler clientHandler)
        {
            Settings = settings;
            SidContainer = sidContainer;
            ServiceProvider = serviceProvider;
            Logger = loggerFactory.CreateLogger<SynologyConnection>();

            Logger.LogDebug($"Creating new connection to {Settings.BaseHost} with{(Settings.Ssl ? "" : "out")} SSL to port {Settings.Port}");

            ClientHandler = clientHandler;
            Client = client;

            Client.BaseAddress = new Uri(Settings.WebApiUrl);
            Client.DefaultRequestHeaders.ExpectContinue = false;
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        public void Dispose()
        {
            Logger.LogDebug("Closing connection");

            Client?.Dispose();
            ClientHandler?.Dispose();
        }
    }
}