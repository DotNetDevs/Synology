namespace Synology.DownloadStation.Info.Results
{
    public interface IInfoResult
    {
        bool IsManager { get; }
        int Version { get; }
        string VersionString { get; }
    }
}