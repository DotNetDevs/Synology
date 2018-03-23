using Newtonsoft.Json;

namespace Synology.DownloadStation.Task.Results
{
    /// <summary>
    /// Task result.
    /// </summary>
	internal class TaskResult : ITaskResult
	{
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [JsonProperty("id")]
		public string Id { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        [JsonProperty("type")]
		public string Type { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>The username.</value>
        [JsonProperty("username")]
		public string Username { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        [JsonProperty("title")]
		public string Title { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>The size.</value>
        [JsonProperty("size")]
		public string Size { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
        [JsonProperty("status")]
		public string Status { get; set; }

        /// <summary>
        /// Gets or sets the additional.
        /// </summary>
        /// <value>The additional.</value>
        [JsonProperty("additional")]
		public TaskAdditionalResult Additional { get; set; }
        ITaskAdditionalResult ITaskResult.Additional => Additional;

        /// <summary>
        /// Gets or sets the status extra.
        /// </summary>
        /// <value>The status extra.</value>
		[JsonProperty("status_extra")]
		public TaskStatusExtraResult StatusExtra { get; set; }
        ITaskStatusExtraResult ITaskResult.StatusExtra => StatusExtra;
	}
}