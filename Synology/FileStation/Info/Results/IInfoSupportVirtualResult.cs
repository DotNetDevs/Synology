namespace Synology.FileStation.Info.Results
{
    /// <summary>
    /// Info support virtual result.
    /// </summary>
    public interface IInfoSupportVirtualResult
    {
        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Info.Results.IInfoSupportVirtualResult"/> enable iso mount.
        /// </summary>
        /// <value><c>true</c> if enable iso mount; otherwise, <c>false</c>.</value>
        bool EnableIsoMount { get; }
        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Info.Results.IInfoSupportVirtualResult"/> enable remote mount.
        /// </summary>
        /// <value><c>true</c> if enable remote mount; otherwise, <c>false</c>.</value>
        bool EnableRemoteMount { get; }
    }
}