namespace Synology.DownloadStation.Info.Results
{
    /// <summary>
    /// Info result.
    /// </summary>
    public interface IInfoResult
    {
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:Synology.DownloadStation.Info.Results.IInfoResult"/> is manager.
        /// </summary>
        /// <value><c>true</c> if is manager; otherwise, <c>false</c>.</value>
        bool IsManager { get; }
        /// <summary>
        /// Gets the version.
        /// </summary>
        /// <value>The version.</value>
        int Version { get; }
        /// <summary>
        /// Gets the version string.
        /// </summary>
        /// <value>The version string.</value>
        string VersionString { get; }
    }
}