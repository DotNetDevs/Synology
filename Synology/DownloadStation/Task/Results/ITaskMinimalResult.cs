namespace Synology.DownloadStation.Task.Results
{
    /// <summary>
    /// Task minimal result.
    /// </summary>
    public interface ITaskMinimalResult
    {
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        string Id { get; }
        /// <summary>
        /// Gets the error.
        /// </summary>
        /// <value>The error.</value>
        int Error { get; }
    }
}