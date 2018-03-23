using Newtonsoft.Json;

namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task perm acl result.
    /// </summary>
    internal abstract class TaskPermAclResult : ITaskPermAclResult
	{
        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Common.Results.TaskPermAclResult"/> is append.
        /// </summary>
        /// <value><c>true</c> if append; otherwise, <c>false</c>.</value>
        [JsonProperty("append")]
		public bool Append { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Common.Results.TaskPermAclResult"/> is delete.
        /// </summary>
        /// <value><c>true</c> if delete; otherwise, <c>false</c>.</value>
        [JsonProperty("del")]
		public bool Delete { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Common.Results.TaskPermAclResult"/> is execute.
        /// </summary>
        /// <value><c>true</c> if execute; otherwise, <c>false</c>.</value>
        [JsonProperty("exec")]
		public bool Execute { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Common.Results.TaskPermAclResult"/> is read.
        /// </summary>
        /// <value><c>true</c> if read; otherwise, <c>false</c>.</value>
        [JsonProperty("read")]
		public bool Read { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Common.Results.TaskPermAclResult"/> is write.
        /// </summary>
        /// <value><c>true</c> if write; otherwise, <c>false</c>.</value>
        [JsonProperty("write")]
		public bool Write { get; set; }
	}

    /// <summary>
    /// Task file perm acl result.
    /// </summary>
    internal abstract class TaskFilePermAclResult : TaskPermAclResult, ITaskFilePermAclResult
    {
    }

    /// <summary>
    /// Task share perm acl result.
    /// </summary>
    internal abstract class TaskSharePermAclResult : TaskPermAclResult, ITaskSharePermAclResult
    {
    }

    /// <summary>
    /// Task virtual folder perm acl result.
    /// </summary>
    internal abstract class TaskVirtualFolderPermAclResult : TaskPermAclResult, ITaskVirtualFolderPermAclResult
    {
    }
}