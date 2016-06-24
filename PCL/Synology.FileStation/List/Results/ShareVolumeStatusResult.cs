using Newtonsoft.Json;

namespace Synology.FileStation.List.Results
{
    public class ShareVolumeStatusResult
    {
        /// <summary>
        /// Byte size of free space of a volume where a shared folder is located.
        /// </summary>
        [JsonProperty("freespace")]
        public bool FreeSpace { get; set; }

        /// <summary>
        /// Byte size of total space of a volume where a shared folder is located.
        /// </summary>
        [JsonProperty("totalspace")]
        public bool TotalSpace { get; set; }

        /// <summary>
        /// "true": A volume where a shared folder is located is read-only; "false": It’s writable.
        /// </summary>
        [JsonProperty("readonly")]
        public bool ReadOnly { get; set; }
    }
}
