using Synology.Interfaces;

namespace Synology.Settings
{
    public class SynologyConnectionSettings : ISynologyConnectionSettings
    {
        public string WebApiUrl { get; }
        public string Username { get; }
        public string Password { get; }
        public string BaseHost { get; }
        public bool SslEnabled { get; }
        public int Port { get; }

        public SynologyConnectionSettings(string baseHost, string username, string password, bool ssl = false, int port = 5000, int sslPort = 5001)
        {
            var usedPort = ssl ? sslPort : port;

            Username = username;
            Password = password;
            WebApiUrl = $"http{(ssl ? "s" : string.Empty)}://{baseHost}:{usedPort}/webapi/";
            BaseHost = baseHost;
            SslEnabled = ssl;
            Port = usedPort;
        }
    }
}
