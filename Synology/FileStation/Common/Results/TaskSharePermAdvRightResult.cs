using Newtonsoft.Json;

namespace Synology.FileStation.Common.Results
{
    /// <summary>
    /// Task share perm adv right result.
    /// </summary>
    public abstract class TaskSharePermAdvRightResult
	{
        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Common.Results.TaskSharePermAdvRightResult"/> disable download.
        /// </summary>
        /// <value><c>true</c> if disable download; otherwise, <c>false</c>.</value>
		[JsonProperty("disable_download")]
		public bool DisableDownload { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Common.Results.TaskSharePermAdvRightResult"/> disable list.
        /// </summary>
        /// <value><c>true</c> if disable list; otherwise, <c>false</c>.</value>
		[JsonProperty("disable_list")]
		public bool DisableList { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.FileStation.Common.Results.TaskSharePermAdvRightResult"/> disable modify.
        /// </summary>
        /// <value><c>true</c> if disable modify; otherwise, <c>false</c>.</value>
		[JsonProperty("disable_modify")]
		public bool DisableModify { get; set; }
	}
}