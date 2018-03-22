using Newtonsoft.Json;

namespace Synology.FileStation.Favorite.Results
{
    /// <summary>
    /// Favorite additional result.
    /// </summary>
	internal class FavoriteAdditionalResult : IFavoriteAdditionalResult
    {
        /// <summary>
        /// Gets or sets the real path.
        /// </summary>
        /// <value>The real path.</value>
		[JsonProperty("real_path")]
        public string RealPath { get; set; }

        /// <summary>
        /// Gets or sets the owner.
        /// </summary>
        /// <value>The owner.</value>
        [JsonProperty("owner")]
        public FavoriteOwnerResult Owner { get; set; }
        IFavoriteOwnerResult IFavoriteAdditionalResult.Owner => Owner;

        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <value>The time.</value>
        [JsonProperty("time")]
        public FavoriteTimeResult Time { get; set; }

        /// <summary>
        /// Gets or sets the perm.
        /// </summary>
        /// <value>The perm.</value>
        [JsonProperty("perm")]
        public FavoritePermResult Perm { get; set; }
        IFavoritePermResult IFavoriteAdditionalResult.Perm => Perm;

        /// <summary>
        /// Gets or sets the type of the mount point.
        /// </summary>
        /// <value>The type of the mount point.</value>
		[JsonProperty("mount_point_type")]
        public string MountPointType { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

