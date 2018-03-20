namespace Synology.DownloadStation.Info.Results
{
    public interface IConfigResult
    {
        int TorrentMaxDownload { get; }
        int TorrentMaxUpload { get; }
        string DefaultDestination { get; }
        string EmuleDefaultDestination { get; }
        bool EmuleEnabled { get; }
        int EmuleMaxDownload { get; }
        int EmuleMaxUpload { get; }
        int FtpMaxDownload { get; }
        int HttpMaxDownload { get; }
        int NzbMaxDownload { get; }
        bool UnzipServiceEnabled { get; }
        bool XunleiEnabled { get; }
    }
}