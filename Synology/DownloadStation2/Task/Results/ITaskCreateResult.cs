using System.Collections.Generic;

namespace Synology.DownloadStation2.Task.Results
{
    /// <summary>
    /// Task create result.
    /// </summary>
    public interface ITaskCreateResult
    {
        /// <summary>
        /// Gets the list identifiers.
        /// </summary>
        /// <value>The list identifiers.</value>
        IEnumerable<string> ListIds { get; }
        /// <summary>
        /// Gets the task identifiers.
        /// </summary>
        /// <value>The task identifiers.</value>
        IEnumerable<string> TaskIds { get; }
    }
}