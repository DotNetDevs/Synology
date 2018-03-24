namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task status result.
    /// </summary>
    public interface ITaskStatusResult
    {
        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Common.Results.ITaskStatusResult"/> is finished.
        /// </summary>
        /// <value><c>true</c> if finished; otherwise, <c>false</c>.</value>
        bool Finished { get; }
    }
}