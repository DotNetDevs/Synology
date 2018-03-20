using Newtonsoft.Json;

namespace Synology.FileStation.Favorite.Results
{
    /// <summary>
    /// Favorite perm result.
    /// </summary>
	public class FavoritePermResult
	{
        /// <summary>
        /// Gets or sets the posix.
        /// </summary>
        /// <value>The posix.</value>
        [JsonProperty("posix")]
		public int Posix { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Favorite.Results.FavoritePermResult"/> is acl mode.
        /// </summary>
        /// <value><c>true</c> if is acl mode; otherwise, <c>false</c>.</value>
		[JsonProperty("is_acl_mode")]
		public bool IsAclMode { get; set; }

        /// <summary>
        /// Gets or sets the acl.
        /// </summary>
        /// <value>The acl.</value>
        [JsonProperty("acl")]
		public FavoritePermAclResult Acl { get; set; }
	}
}