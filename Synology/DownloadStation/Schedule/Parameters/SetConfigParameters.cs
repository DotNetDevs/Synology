using Synology.Utilities;
using Synology.Parameters;

namespace Synology.DownloadStation.Schedule.Parameters
{
    /// <summary>
    /// Set config parameters.
    /// </summary>
	public class SetConfigParameters : RequestParameters
	{
        /// <summary>
        /// Gets or sets the enabled.
        /// </summary>
        /// <value>The enabled.</value>
		public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets the emule enabled.
        /// </summary>
        /// <value>The emule enabled.</value>
		public bool? EmuleEnabled { get; set; }

        /// <summary>
        /// Parameters this instance.
        /// </summary>
        /// <returns>The parameters.</returns>
		public override QueryStringParameter[] Parameters()
		{
			return new[] {
				new QueryStringParameter("enabled", Enabled),
				new QueryStringParameter("emule_enabled", EmuleEnabled)
			};
		}
	}
}

