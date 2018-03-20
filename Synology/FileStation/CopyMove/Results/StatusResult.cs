using Newtonsoft.Json;
using Synology.FileStation.Common.Results;

namespace Synology.FileStation.CopyMove.Results
{
    /// <summary>
    /// Status result.
    /// </summary>
    public class StatusResult : TaskStatusResult
    {
        /// <summary>
        /// If accurate_progress parameter is "true," byte sizes of all copied/moved files will be accumulated.If "false," only byte sizes of the file you give in path parameter is accumulated.
        /// </summary>
        [JsonProperty("processed_size")]
        public int ProgressSize { get; set; }

        /// <summary>
        /// If accurate_progress parameter is "true," the value indicates total byte sizes of files including subfolders will be copied/moved.If "false," it indicates total byte sizes of files you give in path parameter excluding files within subfolders. Otherwise, when the total number is calculating, the value is -1.
        /// </summary>
        [JsonProperty("total")]
        public int ProgressTotal { get; set; }

        /// <summary>
        /// A copying/moving path which you give in path parameter
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }

        /// <summary>
        /// A progress value is between 0~1. It is equal to processed_size parameter divided by total parameter
        /// </summary>
        [JsonProperty("progress")]
        public double ProgressPercent { get; set; }

        /// <summary>
        /// A desitination folder path where files/folders are copied/moved.
        /// </summary>
        [JsonProperty("dest_folder_path")]
        public string DestinationFolder { get; set; }
    }
}
