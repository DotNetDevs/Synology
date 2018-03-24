namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task file additional result.
    /// </summary>
    public interface ITaskFileAdditionalResult<TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult> : ITaskAdditionalResult<TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult>
        where TFileOwnerResult : ITaskFileOwnerResult
        where TFileTimeResult : ITaskFileTimeResult
        where TFilePermResult : ITaskFilePermResult<TFilePermAclResult>
        where TFilePermAclResult : ITaskFilePermAclResult
    {
        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <value>The size.</value>
        long Size { get; }
        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <value>The type.</value>
        string Type { get; }
    }
}