using System;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using Synology.Interfaces;

namespace Synology
{
    public sealed class SynologyConnection : ISynologyConnection
    {
        public ILogger<SynologyConnection> Logger { get; }
        public ISynologyConnectionSettings Settings { get; }
        public HttpClient Client { get; }
        public IServiceProvider ServiceProvider { get; }

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

        public void Dispose()
        {
            Logger.LogDebug("Closing connection");
            Client?.Dispose();
        }
    }
}