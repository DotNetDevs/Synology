using Newtonsoft.Json;
using Synology.Parameters;
using System.ComponentModel.DataAnnotations;
using Synology.Utilities;
using System.ComponentModel;

namespace Synology.FileStation.List.Parameters
{
    public class ListParameters : RequestParameters
    {
        /// <summary>
        /// A listed folder path started with a shared folder.
        /// </summary>
        [Required]
        [JsonProperty("folder_path")]
        public string FolderPath { get; set; }

        /// <summary>
        /// Optional. Specify how many files are skipped before beginning to return listed files
        /// </summary>
        [JsonProperty("offset")]
        public string Offset { get; set; }

        /// <summary>
        /// Optional. Number of files requested. 0 indicates to list all files with a given folder.
        /// </summary>
        [JsonProperty("limit")]
        public string Limit { get; set; }

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
        /// Optional. Given glob pattern(s) to find files whose names and extensions match a case insensitive glob pattern.
        /// Note:
        /// 1. If the pattern doesn’t contain any glob syntax(? and*), * of glob syntax will be added at begin and end of the string automatically for partially matching the pattern.
        /// 2. You can use "," to separate multiple glob patterns
        /// </summary>
        [JsonProperty("pattern")]
        public string Pattern { get; set; }

        /// <summary>
        /// Optional. "file": only enumerate regular files; "dir": only enumerate folders; "all" enumerate regular files and folders
        /// </summary>
        [JsonProperty("filetype")]
        public FileType Filetype { get; set; }

        /// <summary>
        /// Optional. Folder path started with a shared folder. Return all files and sub-folders within folder_path path until goto_path path recursively.
        /// </summary>
        [JsonProperty("goto_path")]
        public string GotoPath { get; set; }

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
        public FileDetailsType Additional { get; set; }

        public override QueryStringParameter[] Parameters()
        {
            return new[]
            {
                new QueryStringParameter("folder_path", FolderPath),
                new QueryStringParameter("offset", Offset),
                new QueryStringParameter("limit", Limit),
                new QueryStringParameter("sort_by", SortBy),
                new QueryStringParameter("sort_direction", SortDirection),
                new QueryStringParameter("pattern", Pattern),
                new QueryStringParameter("filetype", Filetype),
                new QueryStringParameter("goto_path", GotoPath),
                new QueryStringParameter("additional", Additional),
            };
        }
    }
}
