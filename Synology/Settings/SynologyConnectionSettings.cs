using System;
using Synology.Interfaces;

namespace Synology.Settings
{
	/// <inheritdoc />
	/// <summary>
	/// </summary>
	internal class SynologyConnectionSettings : ISynologyConnectionSettings
	{
		/// <inheritdoc />
		/// <summary>
		/// </summary>
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

		/// <inheritdoc />
		/// <summary>
		/// </summary>
		public string Username { get; set; }
		/// <inheritdoc />
		/// <summary>
		/// </summary>
		public string Password { get; set; }
		/// <inheritdoc />
		/// <summary>
		/// </summary>
		public string BaseHost { get; set; }
		/// <inheritdoc />
		/// <summary>
		/// </summary>
		public bool Ssl { get; set; }
		/// <inheritdoc />
		/// <summary>
		/// </summary>
		public int Port { get; set; }
		/// <inheritdoc />
		/// <summary>
		/// </summary>
		public int SslPort { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:Synology.Settings.SynologyConnectionSettings"/>
        /// verify ssl.
        /// </summary>
        /// <value><c>true</c> if verify ssl; otherwise, <c>false</c>.</value>
        public bool VerifySsl { get; set; }
	}
}
