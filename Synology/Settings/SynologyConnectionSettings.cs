using System;
using Synology.Interfaces;

namespace Synology.Settings
{
    public class SynologyConnectionSettings : ISynologyConnectionSettings
    {
        public string WebApiUrl
        {
            get
            {
                if (BaseHost == null) throw new ArgumentNullException(nameof(BaseHost));

                var usedPort = Ssl ? SslPort : Port;
                var protocolSuffix = Ssl ? "s" : string.Empty;
                var protocol = $"http{protocolSuffix}";

                return $"{protocol}://{BaseHost}:{usedPort}/webapi/";
            }
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string BaseHost { get; set; }
        public bool Ssl { get; set; }
        public int Port { get; set; }
        public int SslPort { get; set; }
    }
}
