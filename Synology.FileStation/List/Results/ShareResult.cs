namespace Synology.FileStation.List.Results
{
    public class ShareResult
    {
        /// <summary>
        /// Path of a shared folder.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Name of a shared folder.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Shared-folder additional object.
        /// </summary>
        public ShareAdditional Additional { get; set; }
    }
}
