namespace Synology.FileStation.Favorite.Results
{
    /// <summary>
    /// Favorite time result.
    /// </summary>
    public interface IFavoriteTimeResult
    {
        /// <summary>
        /// Gets the atime.
        /// </summary>
        /// <value>The atime.</value>
        int Atime { get; }
        /// <summary>
        /// Gets the mtime.
        /// </summary>
        /// <value>The mtime.</value>
        int Mtime { get; }
        /// <summary>
        /// Gets the ctime.
        /// </summary>
        /// <value>The ctime.</value>
        int Ctime { get; }
        /// <summary>
        /// Gets the cr time.
        /// </summary>
        /// <value>The cr time.</value>
        int CrTime { get; }
    }
}