namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task share perm adv right result.
    /// </summary>
    public interface ITaskSharePermAdvRightResult
    {
        /// <summary>
        /// Gets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Common.Results.ITaskSharePermAdvRightResult"/> disable download.
        /// </summary>
        /// <value><c>true</c> if disable download; otherwise, <c>false</c>.</value>
        bool DisableDownload { get; }
        /// <summary>
        /// Gets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Common.Results.ITaskSharePermAdvRightResult"/> disable list.
        /// </summary>
        /// <value><c>true</c> if disable list; otherwise, <c>false</c>.</value>
        bool DisableList { get; }
        /// <summary>
        /// Gets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Common.Results.ITaskSharePermAdvRightResult"/> disable modify.
        /// </summary>
        /// <value><c>true</c> if disable modify; otherwise, <c>false</c>.</value>
        bool DisableModify { get; }
    }
}