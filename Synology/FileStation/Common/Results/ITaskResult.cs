namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task result.
    /// </summary>
    public interface ITaskResult<TAdditionalResult, TOwnerResult, TTimeResult, TPermResult, TPermAclResult>
        where TAdditionalResult : ITaskAdditionalResult<TOwnerResult, TTimeResult, TPermResult, TPermAclResult>
        where TOwnerResult : ITaskOwnerResult
        where TTimeResult : ITaskTimeResult
        where TPermResult : ITaskPermResult<TPermAclResult>
        where TPermAclResult : ITaskPermAclResult
    {
        /// <summary>
        /// Gets the path.
        /// </summary>
        /// <value>The path.</value>
        string Path { get; }
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        string Name { get; }
        /// <summary>
        /// Gets the additional.
        /// </summary>
        /// <value>The additional.</value>
        TAdditionalResult Additional { get; }
    }
}