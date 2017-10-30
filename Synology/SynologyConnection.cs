using System;
using System.Linq;
using Newtonsoft.Json;
using Synology.Classes;
using System.Threading.Tasks;
using Synology.Utilities;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using Microsoft.Extensions.Logging;
using Synology.Interfaces;
using Synology.Settings;
using System.Reflection;

namespace Synology
{
    public sealed class SynologyConnection : ISynologyConnection
    {
        public ILogger<SynologyConnection> Logger { get; }
        public ISynologyConnectionSettings Settings { get; }
        public HttpClient Client { get; }
        public IServiceProvider ServiceProvider { get; }
        public string Sid { get; set; }

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