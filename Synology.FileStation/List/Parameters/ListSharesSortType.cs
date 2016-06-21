using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synology.FileStation.List.Parameters
{
    public enum ListSharesSortType
    {
        [Description("name")]
        Name,
        [Description("user")]
        User,
        [Description("group")]
        Group,
        [Description("mtime")]
        LastModifiedTime,
        [Description("atime")]
        LastAccessTime,
        [Description("ctime")]
        LastChangeTime,
        [Description("crtime")]
        CreateTime,
        [Description("posix")]
        Posix
    }
}
