namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task list result.
    /// </summary>
    public interface ITaskListResult
    {
        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        /// <value>The total.</value>
        int Total { get; }
        /// <summary>
        /// Gets or sets the offset.
        /// </summary>
        /// <value>The offset.</value>
        int Offset { get; }
    }
}