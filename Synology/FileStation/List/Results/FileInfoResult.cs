using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Synology.FileStation.List.Results
{
    /// <summary>
    /// File info result.
    /// </summary>
    internal class FileInfoResult : IFileInfoResult
    {
        /// <summary>
        /// Array of <see cref="FileResult"/> objects
        /// </summary>
        [JsonProperty("files")]
        public IEnumerable<FileResult> Files { get; set; }
        IEnumerable<IFileResult> IFileInfoResult.Files => Files.Cast<IFileResult>();
    }
}
