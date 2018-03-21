using Synology.FileStation.Common.Results;

namespace Synology.FileStation.MD5.Results
{
    /// <summary>
    /// MD 5 status result.
    /// </summary>
    public interface IMD5StatusResult : ITaskStatusResult
    {
        /// <summary>
        /// Gets or sets the MD.
        /// </summary>
        /// <value>The MD.</value>
        string MD5 { get; }
    }
}