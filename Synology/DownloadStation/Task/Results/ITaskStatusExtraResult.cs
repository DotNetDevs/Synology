namespace Synology.DownloadStation.Task.Results
{
    /// <summary>
    /// Task status extra result.
    /// </summary>
    public interface ITaskStatusExtraResult
    {
        /// <summary>
        /// Gets the error detail.
        /// </summary>
        /// <value>The error detail.</value>
        string ErrorDetail { get; }
        /// <summary>
        /// Gets the unzip progress.
        /// </summary>
        /// <value>The unzip progress.</value>
        int UnzipProgress { get; }
    }
}