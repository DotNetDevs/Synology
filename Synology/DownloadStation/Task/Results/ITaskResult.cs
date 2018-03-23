namespace Synology.DownloadStation.Task.Results
{
    /// <summary>
    /// Task result.
    /// </summary>
    public interface ITaskResult
    {
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        string Id { get; }
        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <value>The type.</value>
        string Type { get; }
        /// <summary>
        /// Gets the username.
        /// </summary>
        /// <value>The username.</value>
        string Username { get; }
        /// <summary>
        /// Gets the title.
        /// </summary>
        /// <value>The title.</value>
        string Title { get; }
        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <value>The size.</value>
        string Size { get; }
        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <value>The status.</value>
        string Status { get; }
        /// <summary>
        /// Gets the additional.
        /// </summary>
        /// <value>The additional.</value>
        ITaskAdditionalResult Additional { get; }
        /// <summary>
        /// Gets the status extra.
        /// </summary>
        /// <value>The status extra.</value>
        ITaskStatusExtraResult StatusExtra { get; }
    }
}