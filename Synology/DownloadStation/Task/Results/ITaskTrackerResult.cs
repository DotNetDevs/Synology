namespace Synology.DownloadStation.Task.Results
{
    /// <summary>
    /// Task tracker result.
    /// </summary>
    public interface ITaskTrackerResult
    {
        /// <summary>
        /// Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        string Url { get; }
        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <value>The status.</value>
        string Status { get; }
        /// <summary>
        /// Gets the update time.
        /// </summary>
        /// <value>The update time.</value>
        int UpdateTime { get; }
        /// <summary>
        /// Gets the seeds.
        /// </summary>
        /// <value>The seeds.</value>
        int Seeds { get; }
        /// <summary>
        /// Gets the peers.
        /// </summary>
        /// <value>The peers.</value>
        int Peers { get; }
    }
}