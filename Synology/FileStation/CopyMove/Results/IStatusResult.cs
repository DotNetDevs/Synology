using Synology.FileStation.Common.Results;

namespace Synology.FileStation.CopyMove.Results
{
    /// <summary>
    /// Status result.
    /// </summary>
    public interface IStatusResult : ITaskStatusResult
    {
        /// <summary>
        /// Gets or sets the size of the progress.
        /// </summary>
        /// <value>The size of the progress.</value>
        int ProgressSize { get; }
        /// <summary>
        /// Gets or sets the progress total.
        /// </summary>
        /// <value>The progress total.</value>
        int ProgressTotal { get; }
        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>The path.</value>
        string Path { get; }
        /// <summary>
        /// Gets or sets the progress percent.
        /// </summary>
        /// <value>The progress percent.</value>
        double ProgressPercent { get; }
        /// <summary>
        /// Gets or sets the destination folder.
        /// </summary>
        /// <value>The destination folder.</value>
        string DestinationFolder { get; }
    }
}