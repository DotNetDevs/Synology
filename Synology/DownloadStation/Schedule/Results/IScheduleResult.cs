namespace Synology.DownloadStation.Schedule.Results
{
    /// <summary>
    /// Schedule result.
    /// </summary>
    public interface IScheduleResult
    {
        /// <summary>
        /// Gets a value indicating whether this
        /// <see cref="T:Synology.DownloadStation.Schedule.Results.IScheduleResult"/> emule enabled.
        /// </summary>
        /// <value><c>true</c> if emule enabled; otherwise, <c>false</c>.</value>
        bool EmuleEnabled { get; }
        /// <summary>
        /// Gets a value indicating whether this
        /// <see cref="T:Synology.DownloadStation.Schedule.Results.IScheduleResult"/> is enabled.
        /// </summary>
        /// <value><c>true</c> if enabled; otherwise, <c>false</c>.</value>
        bool Enabled { get; }
    }
}