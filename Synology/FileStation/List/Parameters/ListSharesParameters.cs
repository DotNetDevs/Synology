using Newtonsoft.Json;
using Synology.Parameters;
using Synology.Utilities;
using System.ComponentModel;

namespace Synology.FileStation.List.Parameters
{
    /// <summary>
    /// List shares parameters.
    /// </summary>
    public class ListSharesParameters : RequestParameters
    {
        /// <summary>
        /// Optional. Specify how many files are skipped before beginning to return listed files
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// Optional. Number of files requested. 0 indicates to list all files with a given folder.
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// Optional. Specify which file information to sort on.
        /// Options include: 
        /// name: file name
        /// size: file size
        /// user: file owner
        /// group: file group
        /// mtime: last modified time
        /// atime: last access time
        /// ctime: last change time
        /// crtime: create time
        /// posix: POSIX permission
        /// type: file extension
        /// </summary>
        [JsonProperty("sort_by")]
        public ListSortType SortBy { get; set; }

        /// <summary>
        /// Optional. Specify to sort ascending or to sort descending
        /// </summary>
        [JsonProperty("sort_direction")]
        public ListSortDirection SortDirection { get; set; }

        /// <summary>
        /// Optional. "true": List writable shared folders; "false": List writable and read-only shared folders.
        /// </summary>
        [JsonProperty("onlywritable")]
        public bool OnlyWritable { get; set; }

        /// <summary>
        /// Optional. Additional requested file information separated by a comma “, “and around the brackets.When an additional option is requested, responded objects will be provided in the specified additional option.
        /// Options include:
        /// -  real_path: return a real path in volume
        /// -  size: return file byte size
        /// -  owner: return information about file owner including user name, group name, UID and GID
        /// -  time: return information about time including last access time, last modified time, last change time and create time
        /// -  perm: return information about file permission
        /// -  mount_point_type: return a type of a virtual file system of a mount point
        /// -  type: return a file extension
        /// </summary>
        [JsonProperty("additional")]
        public ListSharesDetailsType Additional { get; set; }

        /// <summary>
        /// Parameters this instance.
        /// </summary>
        /// <returns>The parameters.</returns>
        public override QueryStringParameter[] Parameters()
        {
            return new[]
            {
                new QueryStringParameter("offset", Offset),
                new QueryStringParameter("limit", Limit),
                new QueryStringParameter("sort_by", SortBy),
                new QueryStringParameter("sort_direction", SortDirection),
                new QueryStringParameter("onlywritable", OnlyWritable),
                new QueryStringParameter("additional", Additional),
            };
        }
    }
}
