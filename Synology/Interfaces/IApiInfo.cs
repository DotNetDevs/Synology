namespace Synology.Interfaces
{
    /// <summary>
    /// API info.
    /// </summary>
    public interface IApiInfo
    {
        /// <summary>
        /// Gets the path.
        /// </summary>
        /// <value>The path.</value>
        string Path { get; }

        /// <summary>
        /// Gets the minimum version.
        /// </summary>
        /// <value>The minimum version.</value>
        int MinVersion { get; }

        /// <summary>
        /// Gets the max version.
        /// </summary>
        /// <value>The max version.</value>
        int MaxVersion { get; }
    }
}
