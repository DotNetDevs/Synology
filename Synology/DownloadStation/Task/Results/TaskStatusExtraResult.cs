using Newtonsoft.Json;

namespace Synology.DownloadStation.Task.Results
{
    /// <summary>
    /// Task status extra result.
    /// </summary>
	internal class TaskStatusExtraResult : ITaskStatusExtraResult
	{
        /// <summary>
        /// Gets or sets the error detail.
        /// </summary>
        /// <value>The error detail.</value>
		[JsonProperty("error_detail")]
		public string ErrorDetail { get; set; }

        /// <summary>
        /// Gets or sets the unzip progress.
        /// </summary>
        /// <value>The unzip progress.</value>
		[JsonProperty("unzip_progress")]
		public int UnzipProgress { get; set; }
	}
}