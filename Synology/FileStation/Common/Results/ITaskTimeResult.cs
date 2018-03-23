using System;

namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task time result.
    /// </summary>
    public interface ITaskTimeResult
    {
        /// <summary>
        /// Gets the last accessed time.
        /// </summary>
        /// <value>The last accessed time.</value>
        DateTime LastAccessedTime { get; }
        /// <summary>
        /// Gets the last modified time.
        /// </summary>
        /// <value>The last modified time.</value>
        DateTime LastModifiedTime { get; }
        /// <summary>
        /// Gets the last change time.
        /// </summary>
        /// <value>The last change time.</value>
        DateTime LastChangeTime { get; }
        /// <summary>
        /// Gets the created time.
        /// </summary>
        /// <value>The created time.</value>
        DateTime CreatedTime { get; }
    }
}