namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task start result.
    /// </summary>
    public interface ITaskStartResult
    {
        /// <summary>
        /// Gets or sets the task identifier.
        /// </summary>
        /// <value>The task identifier.</value>
        string TaskId { get; set; }
    }
}