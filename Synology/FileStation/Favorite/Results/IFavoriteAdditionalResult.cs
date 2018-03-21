namespace Synology.FileStation.Favorite.Results
{
    /// <summary>
    /// Favorite additional result.
    /// </summary>
    public interface IFavoriteAdditionalResult
    {
        /// <summary>
        /// Gets the real path.
        /// </summary>
        /// <value>The real path.</value>
        string RealPath { get; }
        /// <summary>
        /// Gets the owner.
        /// </summary>
        /// <value>The owner.</value>
        FavoriteOwnerResult Owner { get; }
        /// <summary>
        /// Gets the time.
        /// </summary>
        /// <value>The time.</value>
        FavoriteTimeResult Time { get; }
        /// <summary>
        /// Gets the perm.
        /// </summary>
        /// <value>The perm.</value>
        FavoritePermResult Perm { get; }
        /// <summary>
        /// Gets the type of the mount point.
        /// </summary>
        /// <value>The type of the mount point.</value>
        string MountPointType { get; }
        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <value>The type.</value>
        string Type { get; }
    }
}