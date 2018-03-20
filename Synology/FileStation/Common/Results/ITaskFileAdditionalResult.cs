namespace Synology.FileStation.Common.Results
{
    public interface ITaskFileAdditionalResult<TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult> : ITaskAdditionalResult<TFileOwnerResult, TFileTimeResult, TFilePermResult, TFilePermAclResult>
        where TFileOwnerResult : TaskFileOwnerResult, new()
        where TFileTimeResult : TaskFileTimeResult, new()
        where TFilePermResult : TaskFilePermResult<TFilePermAclResult>, new()
        where TFilePermAclResult : TaskFilePermAclResult, new()
    {
        long Size { get; set; }
        string Type { get; set; }
    }
}