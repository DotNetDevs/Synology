using Newtonsoft.Json;
using Synology.Extensions;
using System;

namespace Synology.FileStation.List.Results
{
    public class ShareTimeResult
    {
        private DateTime aDateTime;
        private DateTime mDateTime;
        private DateTime cDateTime;
        private DateTime crtDateTime;

        public long atime { set { aDateTime = value.ToDateTime(); } }
        public long mtime { set { mDateTime = value.ToDateTime(); } }
        public long ctime { set { cDateTime = value.ToDateTime(); } }
        public long crtime { set { crtDateTime = value.ToDateTime(); } }

        [JsonIgnore]
        public DateTime LastAccessedTime { get { return aDateTime; } }
        [JsonIgnore]
        public DateTime LastModifiedTime { get { return mDateTime; } }
        [JsonIgnore]
        public DateTime LastChangeTime { get { return cDateTime; } }
        [JsonIgnore]
        public DateTime CreatedTime { get { return crtDateTime; } }
    }
}
