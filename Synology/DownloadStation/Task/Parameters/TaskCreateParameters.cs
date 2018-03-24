using Synology.Utilities;
using Synology.Parameters;

namespace Synology.DownloadStation.Task.Parameters
{
    /// <summary>
    /// Task create parameters.
    /// </summary>
	public class TaskCreateParameters : RequestParameters
	{
        /// <summary>
        /// Gets or sets the URI.
        /// </summary>
        /// <value>The URI.</value>
		public string Uri { get; set; }
        /// <summary>
        /// Gets or sets the file.
        /// </summary>
        /// <value>The file.</value>
		public string File { get; set; }
		/// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>The username.</value>
        public string Username { get; set; }
		/// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>The password.</value>
        public string Password { get; set; }
		/// <summary>
        /// Gets or sets the unzip password.
        /// </summary>
        /// <value>The unzip password.</value>
        public string UnzipPassword { get; set; }
		/// <summary>
        /// Gets or sets the destination.
        /// </summary>
        /// <value>The destination.</value>
        public string Destination { get; set; }

        /// <summary>
        /// Parameters this instance.
        /// </summary>
        /// <returns>The parameters.</returns>
		public override QueryStringParameter[] Parameters()
		{
			return new[] {
				new QueryStringParameter("uri", Uri),
				new QueryStringParameter("file", File),
				new QueryStringParameter("username", Username),
				new QueryStringParameter("password", Password),
				new QueryStringParameter("unzip_password", UnzipPassword),
				new QueryStringParameter("destination", Destination),
			};
		}
	}
}
