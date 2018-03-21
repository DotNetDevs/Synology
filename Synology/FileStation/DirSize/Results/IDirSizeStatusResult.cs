using Synology.FileStation.Common.Results;

namespace Synology.FileStation.DirSize.Results
{
    /// <summary>
    /// Dir size status result.
    /// </summary>
    public interface IDirSizeStatusResult : ITaskStatusResult
    {
        /// <summary>
        /// Gets or sets the number dir.
        /// </summary>
        /// <value>The number dir.</value>
        int NumDir { get; }
        /// <summary>
        /// Gets or sets the number file.
        /// </summary>
        /// <value>The number file.</value>
        int NumFile { get; }
        /// <summary>
        /// Gets or sets the total size.
        /// </summary>
        /// <value>The total size.</value>
        int TotalSize { get; }
    }
}