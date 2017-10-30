using System;
using Newtonsoft.Json;
using Synology.Extensions;

namespace Synology.FileStation.Common.Results
{
    public abstract class TaskTimeResult
    {
        private DateTime _aDateTime;
        private DateTime _mDateTime;
        private DateTime _cDateTime;
        private DateTime _crtDateTime;

        [JsonProperty("atime")]
        public long ATime
        {
            set => _aDateTime = value.ToDateTime();
        }

        [JsonProperty("mtime")]
        public long MTime
        {
            set => _mDateTime = value.ToDateTime();
        }

        [JsonProperty("ctime")]
        public long CTime
        {
            set => _cDateTime = value.ToDateTime();
        }

        [JsonProperty("crtime")]
        public long CrTime
        {
            set => _crtDateTime = value.ToDateTime();
        }

        [JsonIgnore]
        public DateTime LastAccessedTime => _aDateTime;
        [JsonIgnore]
        public DateTime LastModifiedTime => _mDateTime;
        [JsonIgnore]
        public DateTime LastChangeTime => _cDateTime;
        [JsonIgnore]
        public DateTime CreatedTime => _crtDateTime;
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
