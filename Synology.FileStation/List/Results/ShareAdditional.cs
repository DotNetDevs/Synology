using Newtonsoft.Json;

namespace Synology.FileStation.List.Results
{
    public class ShareAdditional
    {
        /// <summary>
        /// Real path of a shared folder in a volume space.
        /// </summary>
        [JsonProperty("real_path")]
        public string RealPath { get; set; }

        /// <summary>
        /// File owner information including user name, group name, UID and GID.
        /// </summary>
        public ShareOwnerResult Owner { get; set; }

        /// <summary>
        /// Time information of file including last access time, last modified time, last change time, and creation time
        /// </summary>
        public ShareTimeResult Time { get; set; }

        /// <summary>
        /// File permission information.
        /// </summary>
        [JsonProperty("perm")]
        public SharePermissionResult permissions { get; set; }

        /// <summary>
        /// Type of a virtual file system of a mount point.
        /// </summary>
        [JsonProperty("mount_point_type")]
        public string MountPointType { get; set; }

        /// <summary>
        /// Volume status including free space, total space and read-only status.
        /// </summary>
        [JsonProperty("volume_status")]
        public ShareVolumeStatusResult VolumeStatus { get; set; }
    }
}
