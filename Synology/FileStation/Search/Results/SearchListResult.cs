using System.Collections.Generic;
using Newtonsoft.Json;
using Synology.FileStation.Common.Results;

namespace Synology.FileStation.Search.Results
{
    /// <summary>
    /// Search list result.
    /// </summary>
    public class SearchListResult : TaskStatusResult
	{
        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        /// <value>The total.</value>
        [JsonProperty("total")]
		public int Total { get; set; }

        /// <summary>
        /// Gets or sets the offset.
        /// </summary>
        /// <value>The offset.</value>
        [JsonProperty("offset")]
		public int Offset { get; set; }

        /// <summary>
        /// Gets or sets the files.
        /// </summary>
        /// <value>The files.</value>
        [JsonProperty("files")]
		public IEnumerable<FileResult> Files { get; set; }
	}
}

