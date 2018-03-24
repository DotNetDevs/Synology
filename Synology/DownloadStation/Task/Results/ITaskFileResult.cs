namespace Synology.DownloadStation.Task.Results
{
    /// <summary>
    /// Task file result.
    /// </summary>
    public interface ITaskFileResult
    {
        /// <summary>
        /// Gets or sets the filename.
        /// </summary>
        /// <value>The filename.</value>
        string Filename { get; }
        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>The size.</value>
        string Size { get; }
        /// <summary>
        /// Gets or sets the size downloaded.
        /// </summary>
        /// <value>The size downloaded.</value>
        string SizeDownloaded { get; }
        /// <summary>
        /// Gets or sets the priority.
        /// </summary>
        /// <value>The priority.</value>
        string Priority { get; }
    }
}