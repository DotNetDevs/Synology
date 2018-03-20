using Newtonsoft.Json;
using Synology.FileStation.Common.Results;

namespace Synology.FileStation.DirSize.Results
{
    /// <summary>
    /// Dir size status result.
    /// </summary>
    public class DirSizeStatusResult : TaskStatusResult
	{
        /// <summary>
        /// Gets or sets the number dir.
        /// </summary>
        /// <value>The number dir.</value>
		[JsonProperty("num_dir")]
		public int NumDir { get; set; }

        /// <summary>
        /// Gets or sets the number file.
        /// </summary>
        /// <value>The number file.</value>
		[JsonProperty("num_file")]
		public int NumFile { get; set; }

        /// <summary>
        /// Gets or sets the total size.
        /// </summary>
        /// <value>The total size.</value>
		[JsonProperty("total_size")]
		public int TotalSize { get; set; }
	}
}

