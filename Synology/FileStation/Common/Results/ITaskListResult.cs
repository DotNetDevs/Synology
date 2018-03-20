namespace Synology.FileStation.Common.Results
{
    public interface ITaskListResult
    {
        int Total { get; set; }
        int Offset { get; set; }
    }
}