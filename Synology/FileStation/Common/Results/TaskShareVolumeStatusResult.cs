using System;
using Newtonsoft.Json;

namespace Synology.FileStation.Common.Results
{
    public abstract class TaskVolumeStatusResult
    {
        [JsonProperty("freespace")]
        public long FreeSpace { get; set; }

        [JsonProperty("totalspace")]
        public long TotalSpace { get; set; }

        [JsonProperty("readonly")]
        public bool Readonly { get; set; }
    }

    public abstract class TaskShareVolumeStatusResult : TaskVolumeStatusResult
    {
    }

    public abstract class TaskVirtualFolderVolumeStatusResult : TaskVolumeStatusResult
    {
    }
}