using System.Collections.Generic;

namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task file list result.
    /// </summary>
    public interface ITaskFileListResult<TFileResult, TFileListResult, TFileAdditionalResult, TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult> : ITaskListResult
        where TFileResult : ITaskFileResult<TFileListResult, TFileAdditionalResult, TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult, TFileResult>
        where TFileListResult : ITaskFileListResult<TFileResult, TFileListResult, TFileAdditionalResult, TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult>
        where TFileAdditionalResult : ITaskFileAdditionalResult<TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult>
        where TFileOwnerResult : ITaskFileOwnerResult
        where TFileTimeResult : ITaskFileTimeResult
        where TFilePermResult : ITaskFilePermResult<TFilePermAclResult>
        where TFilePermAclResult : ITaskFilePermAclResult
    {
        /// <summary>
        /// Gets the files.
        /// </summary>
        /// <value>The files.</value>
        IEnumerable<TFileResult> Files { get; }
    }
}