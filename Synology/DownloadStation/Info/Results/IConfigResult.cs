namespace Synology.DownloadStation.Info.Results
{
    /// <summary>
    /// Config result.
    /// </summary>
    public interface IConfigResult
    {
        /// <summary>
        /// Gets the torrent max download.
        /// </summary>
        /// <value>The torrent max download.</value>
        int TorrentMaxDownload { get; }
        /// <summary>
        /// Gets the torrent max upload.
        /// </summary>
        /// <value>The torrent max upload.</value>
        int TorrentMaxUpload { get; }
        /// <summary>
        /// Gets the default destination.
        /// </summary>
        /// <value>The default destination.</value>
        string DefaultDestination { get; }
        /// <summary>
        /// Gets the emule default destination.
        /// </summary>
        /// <value>The emule default destination.</value>
        string EmuleDefaultDestination { get; }
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:Synology.DownloadStation.Info.Results.IConfigResult"/>
        /// emule enabled.
        /// </summary>
        /// <value><c>true</c> if emule enabled; otherwise, <c>false</c>.</value>
        bool EmuleEnabled { get; }
        /// <summary>
        /// Gets the emule max download.
        /// </summary>
        /// <value>The emule max download.</value>
        int EmuleMaxDownload { get; }
        /// <summary>
        /// Gets the emule max upload.
        /// </summary>
        /// <value>The emule max upload.</value>
        int EmuleMaxUpload { get; }
        /// <summary>
        /// Gets the ftp max download.
        /// </summary>
        /// <value>The ftp max download.</value>
        int FtpMaxDownload { get; }
        /// <summary>
        /// Gets the http max download.
        /// </summary>
        /// <value>The http max download.</value>
        int HttpMaxDownload { get; }
        /// <summary>
        /// Gets the nzb max download.
        /// </summary>
        /// <value>The nzb max download.</value>
        int NzbMaxDownload { get; }
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:Synology.DownloadStation.Info.Results.IConfigResult"/>
        /// unzip service enabled.
        /// </summary>
        /// <value><c>true</c> if unzip service enabled; otherwise, <c>false</c>.</value>
        bool UnzipServiceEnabled { get; }
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:Synology.DownloadStation.Info.Results.IConfigResult"/>
        /// xunlei enabled.
        /// </summary>
        /// <value><c>true</c> if xunlei enabled; otherwise, <c>false</c>.</value>
        bool XunleiEnabled { get; }
    }
}