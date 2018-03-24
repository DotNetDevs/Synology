namespace Synology.FileStation.Favorite.Results
{
    /// <summary>
    /// Favorite perm result.
    /// </summary>
    public interface IFavoritePermResult
    {
        /// <summary>
        /// Gets or sets the posix.
        /// </summary>
        /// <value>The posix.</value>
        int Posix { get; }
        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Favorite.Results.IFavoritePermResult"/> is acl mode.
        /// </summary>
        /// <value><c>true</c> if is acl mode; otherwise, <c>false</c>.</value>
        bool IsAclMode { get; }
        /// <summary>
        /// Gets or sets the acl.
        /// </summary>
        /// <value>The acl.</value>
        IFavoritePermAclResult Acl { get; }
    }
}