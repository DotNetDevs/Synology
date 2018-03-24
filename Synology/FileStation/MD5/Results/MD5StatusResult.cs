using Newtonsoft.Json;
using Synology.FileStation.Common.Results;

namespace Synology.FileStation.MD5.Results
{
    /// <summary>
    /// MD 5 status result.
    /// </summary>
    internal class MD5StatusResult : TaskStatusResult, IMD5StatusResult
	{
        /// <summary>
        /// Gets or sets the MD.
        /// </summary>
        /// <value>The MD.</value>
        [JsonProperty("md5")]
		public string MD5 { get; set; }
	}
}

