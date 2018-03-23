namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task perm acl result.
    /// </summary>
    public interface ITaskPermAclResult
    {
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:Synology.FileStation.Common.Results.ITaskPermAclResult"/>
        /// is append.
        /// </summary>
        /// <value><c>true</c> if append; otherwise, <c>false</c>.</value>
        bool Append { get; }
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:Synology.FileStation.Common.Results.ITaskPermAclResult"/>
        /// is delete.
        /// </summary>
        /// <value><c>true</c> if delete; otherwise, <c>false</c>.</value>
        bool Delete { get; }
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:Synology.FileStation.Common.Results.ITaskPermAclResult"/>
        /// is execute.
        /// </summary>
        /// <value><c>true</c> if execute; otherwise, <c>false</c>.</value>
        bool Execute { get; }
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:Synology.FileStation.Common.Results.ITaskPermAclResult"/>
        /// is read.
        /// </summary>
        /// <value><c>true</c> if read; otherwise, <c>false</c>.</value>
        bool Read { get; }
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:Synology.FileStation.Common.Results.ITaskPermAclResult"/>
        /// is write.
        /// </summary>
        /// <value><c>true</c> if write; otherwise, <c>false</c>.</value>
        bool Write { get; }
    }
}