using System.Collections.Generic;

namespace Synology.DownloadStation.Task.Results
{
    /// <summary>
    /// Task additional result.
    /// </summary>
    public interface ITaskAdditionalResult
    {
        /// <summary>
        /// Gets the detail.
        /// </summary>
        /// <value>The detail.</value>
        ITaskDetailResult Detail { get; }
        /// <summary>
        /// Gets the transfer.
        /// </summary>
        /// <value>The transfer.</value>
        ITaskTransferResult Transfer { get; }
        /// <summary>
        /// Gets the file.
        /// </summary>
        /// <value>The file.</value>
        IEnumerable<ITaskFileResult> File { get; }
        /// <summary>
        /// Gets the tracker.
        /// </summary>
        /// <value>The tracker.</value>
        IEnumerable<ITaskTrackerResult> Tracker { get; }
        /// <summary>
        /// Gets the peer.
        /// </summary>
        /// <value>The peer.</value>
        IEnumerable<ITaskPeerResult> Peer { get; }
    }
}