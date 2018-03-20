using System;
using Newtonsoft.Json;
using Synology;

namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task time result.
    /// </summary>
    public abstract class TaskTimeResult
    {
        private DateTime _aDateTime;
        private DateTime _mDateTime;
        private DateTime _cDateTime;
        private DateTime _crtDateTime;

        /// <summary>
        /// Sets AT IME.
        /// </summary>
        /// <value>AT IME.</value>
        [JsonProperty("atime")]
        public long ATime
        {
            set => _aDateTime = value.ToDateTime();
        }

        /// <summary>
        /// Sets the MT IME.
        /// </summary>
        /// <value>The MT IME.</value>
        [JsonProperty("mtime")]
        public long MTime
        {
            set => _mDateTime = value.ToDateTime();
        }

        /// <summary>
        /// Sets the CT IME.
        /// </summary>
        /// <value>The CT IME.</value>
        [JsonProperty("ctime")]
        public long CTime
        {
            set => _cDateTime = value.ToDateTime();
        }

        /// <summary>
        /// Sets the cr time.
        /// </summary>
        /// <value>The cr time.</value>
        [JsonProperty("crtime")]
        public long CrTime
        {
            set => _crtDateTime = value.ToDateTime();
        }

        /// <summary>
        /// Gets the last accessed time.
        /// </summary>
        /// <value>The last accessed time.</value>
        [JsonIgnore]
        public DateTime LastAccessedTime => _aDateTime;

        /// <summary>
        /// Gets the last modified time.
        /// </summary>
        /// <value>The last modified time.</value>
        [JsonIgnore]
        public DateTime LastModifiedTime => _mDateTime;

        /// <summary>
        /// Gets the last change time.
        /// </summary>
        /// <value>The last change time.</value>
        [JsonIgnore]
        public DateTime LastChangeTime => _cDateTime;

        /// <summary>
        /// Gets the created time.
        /// </summary>
        /// <value>The created time.</value>
        [JsonIgnore]
        public DateTime CreatedTime => _crtDateTime;
    }

    /// <summary>
    /// Task file time result.
    /// </summary>
    public abstract class TaskFileTimeResult : TaskTimeResult
    {
    }

    /// <summary>
    /// Task share time result.
    /// </summary>
    public abstract class TaskShareTimeResult : TaskTimeResult
    {
    }

    /// <summary>
    /// Task virtual folder time result.
    /// </summary>
    public abstract class TaskVirtualFolderTimeResult : TaskTimeResult
    {
    }
}
