using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synology.FileStation.List.Results
{
    public class ListResult
    {
        /// <summary>
        /// Total number of shared files.
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// Requested offset.
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// List of <see cref="FileResult"/> objects. 
        /// </summary>
        public IEnumerable<FileResult> Files { get; set; }
    }
}
