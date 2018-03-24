namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task volume status result.
    /// </summary>
    public interface ITaskVolumeStatusResult
    {
        /// <summary>
        /// Gets or sets the free space.
        /// </summary>
        /// <value>The free space.</value>
        long FreeSpace { get; }
        /// <summary>
        /// Gets or sets the total space.
        /// </summary>
        /// <value>The total space.</value>
        long TotalSpace { get; }
        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Common.Results.ITaskVolumeStatusResult"/> is readonly.
        /// </summary>
        /// <value><c>true</c> if readonly; otherwise, <c>false</c>.</value>
        bool Readonly { get; }
    }
}