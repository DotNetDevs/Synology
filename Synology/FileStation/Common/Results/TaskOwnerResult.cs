using Newtonsoft.Json;

namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task owner result.
    /// </summary>
    public abstract class TaskOwnerResult
    {
        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>The user.</value>
        [JsonProperty("user")]
        public string User { get; set; }

        /// <summary>
        /// Gets or sets the group.
        /// </summary>
        /// <value>The group.</value>
        [JsonProperty("group")]
        public string Group { get; set; }

        /// <summary>
        /// Gets or sets the uid.
        /// </summary>
        /// <value>The uid.</value>
        [JsonProperty("uid")]
        public int Uid { get; set; }

        /// <summary>
        /// Gets or sets the gid.
        /// </summary>
        /// <value>The gid.</value>
        [JsonProperty("gid")]
        public int Gid { get; set; }
    }

    /// <summary>
    /// Task file owner result.
    /// </summary>
    public abstract class TaskFileOwnerResult : TaskOwnerResult
    {
    }

    /// <summary>
    /// Task share owner result.
    /// </summary>
    public abstract class TaskShareOwnerResult : TaskOwnerResult
    {
    }

    /// <summary>
    /// Task virtual folder owner result.
    /// </summary>
    public abstract class TaskVirtualFolderOwnerResult : TaskOwnerResult
    {
    }
}