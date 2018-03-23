using System.Collections.Generic;

namespace Synology.FileStation.List.Results
{
    /// <summary>
    /// File info result.
    /// </summary>
    public interface IFileInfoResult
    {
        /// <summary>
        /// Gets the files.
        /// </summary>
        /// <value>The files.</value>
        IEnumerable<IFileResult> Files { get; }
    }
}