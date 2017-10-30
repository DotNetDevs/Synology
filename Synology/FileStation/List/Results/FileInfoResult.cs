using System.Collections.Generic;
using Newtonsoft.Json;

namespace Synology.FileStation.List.Results
{
    public class FileInfoResult
    {
        /// <summary>
        /// Array of <see cref="FileResult"/> objects
        /// </summary>
        [JsonProperty("files")]
        public IEnumerable<FileResult> Files { get; set; }
    }
}
