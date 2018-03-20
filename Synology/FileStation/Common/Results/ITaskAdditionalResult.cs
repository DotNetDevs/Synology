namespace Synology.FileStation.Common.Results
{
    public interface ITaskAdditionalResult<TOwnerResult, TTimeResult, TPermResult, TPermAclResult>
        where TOwnerResult : TaskOwnerResult
        where TTimeResult : TaskTimeResult, new()
        where TPermResult : TaskPermResult<TPermAclResult>, new()
        where TPermAclResult : TaskPermAclResult, new()
    {
        string RealPath { get; set; }
        TOwnerResult Owner { get; set; }
        TTimeResult Time { get; set; }
        TPermResult Perm { get; set; }
        string MountPointType { get; set; }
    }
}