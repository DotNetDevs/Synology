using Newtonsoft.Json;

namespace Synology.FileStation.Favorite.Results
{
    /// <summary>
    /// Favorite perm acl result.
    /// </summary>
    internal class FavoritePermAclResult : IFavoritePermAclResult
	{
        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Favorite.Results.FavoritePermAclResult"/> is append.
        /// </summary>
        /// <value><c>true</c> if append; otherwise, <c>false</c>.</value>
        [JsonProperty("append")]
		public bool Append { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Favorite.Results.FavoritePermAclResult"/> is delete.
        /// </summary>
        /// <value><c>true</c> if delete; otherwise, <c>false</c>.</value>
        [JsonProperty("del")]
		public bool Delete { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Favorite.Results.FavoritePermAclResult"/> is execute.
        /// </summary>
        /// <value><c>true</c> if execute; otherwise, <c>false</c>.</value>
        [JsonProperty("exec")]
		public bool Execute { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Favorite.Results.FavoritePermAclResult"/> is read.
        /// </summary>
        /// <value><c>true</c> if read; otherwise, <c>false</c>.</value>
        [JsonProperty("read")]
		public bool Read { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Favorite.Results.FavoritePermAclResult"/> is write.
        /// </summary>
        /// <value><c>true</c> if write; otherwise, <c>false</c>.</value>
        [JsonProperty("write")]
		public bool Write { get; set; }
	}
}