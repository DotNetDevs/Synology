using System.Collections.Generic;

namespace Synology.FileStation.List.Results
{
    public class GetFileInfoResult
    {
        /// <summary>
        /// Array of <see cref="FileResult"/> objects
        /// </summary>
        public IEnumerable<FileResult> Files { get; set; }
    }
}
