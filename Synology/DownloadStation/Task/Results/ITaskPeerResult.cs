namespace Synology.DownloadStation.Task.Results
{
    /// <summary>
    /// Task peer result.
    /// </summary>
    public interface ITaskPeerResult
    {
        /// <summary>
        /// Gets the address.
        /// </summary>
        /// <value>The address.</value>
        string Address { get; }
        /// <summary>
        /// Gets the agent.
        /// </summary>
        /// <value>The agent.</value>
        string Agent { get; }
        /// <summary>
        /// Gets the progress.
        /// </summary>
        /// <value>The progress.</value>
        float Progress { get; }
        /// <summary>
        /// Gets the speed download.
        /// </summary>
        /// <value>The speed download.</value>
        int SpeedDownload { get; }
        /// <summary>
        /// Gets the speed upload.
        /// </summary>
        /// <value>The speed upload.</value>
        int SpeedUpload { get; }
    }
}