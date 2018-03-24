namespace Synology.Interfaces
{
    /// <summary>
    /// Synology connection settings.
    /// </summary>
    public interface ISynologyConnectionSettings
    {
        /// <summary>
        /// Gets the web API URL.
        /// </summary>
        /// <value>The web API URL.</value>
        string WebApiUrl { get; }
        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>The username.</value>
        string Username { get; set; }
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>The password.</value>
        string Password { get; set; }
        /// <summary>
        /// Gets or sets the base host.
        /// </summary>
        /// <value>The base host.</value>
        string BaseHost { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:Synology.Interfaces.ISynologyConnectionSettings"/> is ssl.
        /// </summary>
        /// <value><c>true</c> if ssl; otherwise, <c>false</c>.</value>
        bool Ssl { get; set; }
        /// <summary>
        /// Gets or sets the port.
        /// </summary>
        /// <value>The port.</value>
        int Port { get; set; }
        /// <summary>
        /// Gets or sets the ssl port.
        /// </summary>
        /// <value>The ssl port.</value>
        int SslPort { get; set; }
    }
}
