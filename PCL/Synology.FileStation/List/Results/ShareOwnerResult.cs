namespace Synology.FileStation.List.Results
{
    public class ShareOwnerResult
    {
        /// <summary>
        /// User name of file owner.
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Group name of file group.
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        /// File UID.
        /// </summary>
        public string Uid { get; set; }

        /// <summary>
        /// File GID.
        /// </summary>
        public string Gid { get; set; }
    }
}
