using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synology.FileStation.List.Results
{
    public class ListSharesResult
    {
        /// <summary>
        /// Total number of shared folders.
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// Requested offset.
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// List of <see cref="ShareResult"/> objects. 
        /// </summary>
        public List<ShareResult> Shares { get; set; }
    }
}
