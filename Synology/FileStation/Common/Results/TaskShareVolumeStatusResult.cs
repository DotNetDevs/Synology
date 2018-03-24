using Newtonsoft.Json;

namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task volume status result.
    /// </summary>
    internal abstract class TaskVolumeStatusResult : ITaskVolumeStatusResult
    {
        /// <summary>
        /// Gets or sets the free space.
        /// </summary>
        /// <value>The free space.</value>
        [JsonProperty("freespace")]
        public long FreeSpace { get; set; }

        /// <summary>
        /// Gets or sets the total space.
        /// </summary>
        /// <value>The total space.</value>
        [JsonProperty("totalspace")]
        public long TotalSpace { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Common.Results.TaskVolumeStatusResult"/> is readonly.
        /// </summary>
        /// <value><c>true</c> if readonly; otherwise, <c>false</c>.</value>
        [JsonProperty("readonly")]
        public bool Readonly { get; set; }
    }

    /// <summary>
    /// Task share volume status result.
    /// </summary>
    internal abstract class TaskShareVolumeStatusResult : TaskVolumeStatusResult, ITaskShareVolumeStatusResult
    {
    }

    /// <summary>
    /// Task virtual folder volume status result.
    /// </summary>
    internal abstract class TaskVirtualFolderVolumeStatusResult : TaskVolumeStatusResult, ITaskVirtualFolderVolumeStatusResult
    {
    }
}