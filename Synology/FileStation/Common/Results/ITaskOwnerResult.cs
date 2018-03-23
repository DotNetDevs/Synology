namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task owner result.
    /// </summary>
    public interface ITaskOwnerResult
    {
        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <value>The user.</value>
        string User { get; }
        /// <summary>
        /// Gets the group.
        /// </summary>
        /// <value>The group.</value>
        string Group { get; }
        /// <summary>
        /// Gets the uid.
        /// </summary>
        /// <value>The uid.</value>
        int Uid { get; }
        /// <summary>
        /// Gets the gid.
        /// </summary>
        /// <value>The gid.</value>
        int Gid { get; }
    }
}