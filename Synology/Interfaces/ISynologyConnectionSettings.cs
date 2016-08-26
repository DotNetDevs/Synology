using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synology.Interfaces
{
    public interface ISynologyConnectionSettings
    {
        string WebApiUrl { get; }
        string Username { get; }
        string Password { get; }
        string BaseHost { get; }
        bool SslEnabled { get; }
        int Port { get; }
    }
}
