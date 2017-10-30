using System;
using Newtonsoft.Json;
using Synology.Extensions;

namespace Synology.FileStation.Common.Results
{
    public abstract class TaskTimeResult
    {
        private DateTime aDateTime;
        private DateTime mDateTime;
        private DateTime cDateTime;
        private DateTime crtDateTime;

        [JsonProperty("atime")]
        public long ATime
        {
            set => aDateTime = value.ToDateTime();
        }

        [JsonProperty("mtime")]
        public long MTime
        {
            set => mDateTime = value.ToDateTime();
        }

        [JsonProperty("ctime")]
        public long CTime
        {
            set => cDateTime = value.ToDateTime();
        }

        [JsonProperty("crtime")]
        public long CrTime
        {
            set => crtDateTime = value.ToDateTime();
        }

        [JsonIgnore]
        public DateTime LastAccessedTime => aDateTime;
        [JsonIgnore]
        public DateTime LastModifiedTime => mDateTime;
        [JsonIgnore]
        public DateTime LastChangeTime => cDateTime;
        [JsonIgnore]
        public DateTime CreatedTime => crtDateTime;
    }

    public abstract class TaskFileTimeResult : TaskTimeResult
    {
    }

    public abstract class TaskShareTimeResult : TaskTimeResult
    {
    }

    public abstract class TaskVirtualFolderTimeResult : TaskTimeResult
    {
    }
}
