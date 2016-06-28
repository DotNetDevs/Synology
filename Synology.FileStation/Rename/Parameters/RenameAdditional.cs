using Synology.Attributes;
using System;
using System.ComponentModel;

namespace Synology.FileStation.Rename.Parameters
{
    [Flags]
    public enum RenameAdditional
    {
        /// <summary>
        /// Return a real path in volume
        /// </summary>
        [Description("real_path")]
        RealPath = 1 << 0,
        /// <summary>
        /// Return file byte size
        /// </summary>
        [Description("size")]
        Size = 1 << 1,
        /// <summary>
        ///  Return information about file owner including user name, group name, UID and GID
        /// </summary>
        [Description("owner")]
        Owner = 1 << 2,
        /// <summary>
        /// Return information about time including last access time, last modified time, last change time and create time
        /// </summary>
        [Description("time")]
        Time = 1 << 3,
        /// <summary>
        /// Return information about file permission
        /// </summary>
        [Description("perm")]
        Perm = 1 << 4,
        /// <summary>
        /// Return a file extension
        /// </summary>
        [Description("type")]
        Type = 1 << 5
    }
}
