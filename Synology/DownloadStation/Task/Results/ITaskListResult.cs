using System.Collections.Generic;

namespace Synology.DownloadStation.Task.Results
{
    /// <summary>
    /// Task list result.
    /// </summary>
    public interface ITaskListResult
    {
        /// <summary>
        /// Gets the offset.
        /// </summary>
        /// <value>The offset.</value>
        int Offset { get; }
        /// <summary>
        /// Gets the tasks.
        /// </summary>
        /// <value>The tasks.</value>
        IEnumerable<ITaskResult> Tasks { get; }
        /// <summary>
        /// Gets the total.
        /// </summary>
        /// <value>The total.</value>
        int Total { get; }
    }
}