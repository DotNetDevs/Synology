using Newtonsoft.Json;

namespace Synology.FileStation.Favorite.Results
{
    /// <summary>
    /// Favorite time result.
    /// </summary>
	public class FavoriteTimeResult
	{
        /// <summary>
        /// Gets or sets the atime.
        /// </summary>
        /// <value>The atime.</value>
        [JsonProperty("atime")]
		public int Atime { get; set; }

        /// <summary>
        /// Gets or sets the mtime.
        /// </summary>
        /// <value>The mtime.</value>
        [JsonProperty("mtime")]
		public int Mtime { get; set; }

        /// <summary>
        /// Gets or sets the ctime.
        /// </summary>
        /// <value>The ctime.</value>
        [JsonProperty("ctime")]
		public int Ctime { get; set; }

        /// <summary>
        /// Gets or sets the cr time.
        /// </summary>
        /// <value>The cr time.</value>
        [JsonProperty("crtime")]
		public int CrTime { get; set; }
	}
}