namespace Synology.FileStation.Favorite.Results
{
    /// <summary>
    /// Favorite result.
    /// </summary>
    public interface IFavoriteResult
    {
        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>The path.</value>
        string Path { get; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        string Name { get; }
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
        string Status { get; }
        /// <summary>
        /// Gets or sets the additional.
        /// </summary>
        /// <value>The additional.</value>
        IFavoriteAdditionalResult Additional { get; }
    }
}