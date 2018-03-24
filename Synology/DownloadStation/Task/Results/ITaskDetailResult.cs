namespace Synology.DownloadStation.Task.Results
{
    /// <summary>
    /// Task detail result.
    /// </summary>
    public interface ITaskDetailResult
    {
        /// <summary>
        /// Gets the destination.
        /// </summary>
        /// <value>The destination.</value>
        string Destination { get; }
        /// <summary>
        /// Gets or sets the URI.
        /// </summary>
        /// <value>The URI.</value>
        string Uri { get; }
        /// <summary>
        /// Gets the create time.
        /// </summary>
        /// <value>The create time.</value>
        int CreateTime { get; }
        /// <summary>
        /// Gets the priority.
        /// </summary>
        /// <value>The priority.</value>
        string Priority { get; }
        /// <summary>
        /// Gets the total peers.
        /// </summary>
        /// <value>The total peers.</value>
        int TotalPeers { get; }
        /// <summary>
        /// Gets the connected seeders.
        /// </summary>
        /// <value>The connected seeders.</value>
        int ConnectedSeeders { get; }
        /// <summary>
        /// Gets the connected leechers.
        /// </summary>
        /// <value>The connected leechers.</value>
        int ConnectedLeechers { get; }
    }
}