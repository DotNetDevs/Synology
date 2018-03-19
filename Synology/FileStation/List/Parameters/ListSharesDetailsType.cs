using System;
using System.ComponentModel;

namespace Synology.FileStation.List.Parameters
{
    [Flags]
    public enum ListSharesDetailsType
    {
        /// <summary>
        /// Return a real path in volume
        /// </summary>
        [Description("real_path")]
        RealPath = 1 << 0,
        /// <summary>
        /// return file byte size
        /// </summary>
        [Description("size")]
        Size = 1 << 1,
        /// <summary>
        /// return information about file owner including user name, group name, UID and GID
        /// </summary>
        [Description("owner")]
        Owner = 1 << 2,
        /// <summary>
        /// return information about time including last access time, last modified time, last change time and create time
        /// </summary>
        [Description("time")]
        Time = 1 << 3,
        /// <summary>
        /// return information about file permission
        /// </summary>
        [Description("perm")]
        Perm = 1 << 4,
        /// <summary>
        /// return a type of a virtual file system of a mount point
        /// </summary>
        [Description("mount_point_type")]
        MountPointType = 1 << 5,
        /// <summary>
        ///  return volume statuses including free space, total space and read-only status
        /// </summary>
        [Description("volume_status")]
        Type = 1 << 6
    }
}
