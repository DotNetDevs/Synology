using System.Collections.Generic;
using Synology.FileStation.Common.Results;

namespace Synology.FileStation.Search.Results
{
    /// <summary>
    /// Search list result.
    /// </summary>
    public interface ISearchListResult : ITaskStatusResult
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
        /// <summary>
        /// Gets or sets the files.
        /// </summary>
        /// <value>The files.</value>
        IEnumerable<FileResult> Files { get; }
    }
}