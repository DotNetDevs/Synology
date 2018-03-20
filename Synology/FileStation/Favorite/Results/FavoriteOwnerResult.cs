using Newtonsoft.Json;

namespace Synology.FileStation.Favorite.Results
{
    /// <summary>
    /// Favorite owner result.
    /// </summary>
	public class FavoriteOwnerResult
	{
        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>The user.</value>
        [JsonProperty("user")]
		public string User { get; set; }

        /// <summary>
        /// Gets or sets the group.
        /// </summary>
        /// <value>The group.</value>
        [JsonProperty("group")]
		public string Group { get; set; }

        /// <summary>
        /// Gets or sets the uid.
        /// </summary>
        /// <value>The uid.</value>
        [JsonProperty("uid")]
		public int Uid { get; set; }

        /// <summary>
        /// Gets or sets the gid.
        /// </summary>
        /// <value>The gid.</value>
        [JsonProperty("gid")]
		public int Gid { get; set; }
	}
}