namespace Synology.FileStation.Favorite.Results
{
    /// <summary>
    /// Favorite perm acl result.
    /// </summary>
    public interface IFavoritePermAclResult
    {
        /// <summary>
        /// Gets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Favorite.Results.IFavoritePermAclResult"/> is append.
        /// </summary>
        /// <value><c>true</c> if append; otherwise, <c>false</c>.</value>
        bool Append { get; }
        /// <summary>
        /// Gets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Favorite.Results.IFavoritePermAclResult"/> is delete.
        /// </summary>
        /// <value><c>true</c> if delete; otherwise, <c>false</c>.</value>
        bool Delete { get; }
        /// <summary>
        /// Gets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Favorite.Results.IFavoritePermAclResult"/> is execute.
        /// </summary>
        /// <value><c>true</c> if execute; otherwise, <c>false</c>.</value>
        bool Execute { get; }
        /// <summary>
        /// Gets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Favorite.Results.IFavoritePermAclResult"/> is read.
        /// </summary>
        /// <value><c>true</c> if read; otherwise, <c>false</c>.</value>
        bool Read { get; }
        /// <summary>
        /// Gets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Favorite.Results.IFavoritePermAclResult"/> is write.
        /// </summary>
        /// <value><c>true</c> if write; otherwise, <c>false</c>.</value>
        bool Write { get; }
    }
}