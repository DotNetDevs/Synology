using System;
using System.Net.Http;
using Microsoft.Extensions.Logging;

namespace Synology.Interfaces
{
    public interface ISynologyConnection : IDisposable
    {
        ILogger<SynologyConnection> Logger { get; }

        string Sid { get; set; }

        ISynologyConnectionSettings Settings { get; }

        HttpClient Client { get; }

        IServiceProvider ServiceProvider { get; }
    }
}
