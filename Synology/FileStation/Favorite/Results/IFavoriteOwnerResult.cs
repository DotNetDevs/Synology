namespace Synology.FileStation.Favorite.Results
{
    /// <summary>
    /// Favorite owner result.
    /// </summary>
    public interface IFavoriteOwnerResult
    {
        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <value>The user.</value>
        string User { get; }
        /// <summary>
        /// Gets the group.
        /// </summary>
        /// <value>The group.</value>
        string Group { get; }
        /// <summary>
        /// Gets the uid.
        /// </summary>
        /// <value>The uid.</value>
        int Uid { get; }
        /// <summary>
        /// Gets the gid.
        /// </summary>
        /// <value>The gid.</value>
        int Gid { get; }
    }
}