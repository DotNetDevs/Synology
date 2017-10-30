namespace Synology.Interfaces
{
    public interface ISynologyConnectionSettings
    {
        string WebApiUrl { get; }
        string Username { get; set; }
        string Password { get; set; }
        string BaseHost { get; set; }
        bool Ssl { get; set; }
        int Port { get; set; }
        int SslPort { get; set; }
    }
}
