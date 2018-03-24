using System.Collections.Generic;

namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task file result.
    /// </summary>
    public interface ITaskFileResult<TFileListResult, TFileAdditionalResult, TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult, TFileResult> : ITaskResult<TFileAdditionalResult, TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult>
        where TFileListResult : ITaskFileListResult<TFileResult, TFileListResult, TFileAdditionalResult, TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult>
        where TFileAdditionalResult : ITaskFileAdditionalResult<TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult>
        where TFileOwnerResult : ITaskFileOwnerResult
        where TFileTimeResult : ITaskFileTimeResult
        where TFilePermResult : ITaskFilePermResult<TFilePermAclResult>
        where TFilePermAclResult : ITaskFilePermAclResult
        where TFileResult : ITaskFileResult<TFileListResult, TFileAdditionalResult, TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult, TFileResult>
    {
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:Synology.FileStation.Common.Results.ITaskFileResult`7"/>
        /// is dir.
        /// </summary>
        /// <value><c>true</c> if is dir; otherwise, <c>false</c>.</value>
        bool IsDir { get; }
        /// <summary>
        /// Gets the children.
        /// </summary>
        /// <value>The children.</value>
        IEnumerable<TFileListResult> Children { get; }
    }
}