namespace Synology.DownloadStation.Task.Results
{
    /// <summary>
    /// Task transfer result.
    /// </summary>
    public interface ITaskTransferResult
    {
        /// <summary>
        /// Gets or sets the size downloaded.
        /// </summary>
        /// <value>The size downloaded.</value>
        string SizeDownloaded { get; }
        /// <summary>
        /// Gets or sets the size uploaded.
        /// </summary>
        /// <value>The size uploaded.</value>
        string SizeUploaded { get; }
        /// <summary>
        /// Gets or sets the speed download.
        /// </summary>
        /// <value>The speed download.</value>
        int SpeedDownload { get; }
        /// <summary>
        /// Gets or sets the speed upload.
        /// </summary>
        /// <value>The speed upload.</value>
        int SpeedUpload { get; }
    }
}