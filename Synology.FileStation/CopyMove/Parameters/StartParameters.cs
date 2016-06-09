using Synology.Classes;
using System;
using Synology.Utilities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Synology.FileStation.CopyMove.Parameters
{
    public class StartParameters : RequestParameters
    {
        /// <summary>
        /// One or more files or folder to move / copy
        /// </summary>
        /// <remarks>
        /// One or more copied/moved file/folder path(s) starting with a shared folder, separated by commas ","and around brackets.
        /// </remarks>
        [Required]
        public IEnumerable<string> Path { get; set; }

        /// <summary>
        /// The destination folder to which files or folders are to be copied / moved
        /// </summary>
        /// <remarks>
        /// A desitination folder path where files/folders are copied/moved.
        /// </remarks>
        [Required]
        [JsonProperty("dest_folder_path")]
        public string DestinationFolder { get; set; }

        /// <summary>
        /// Overwrite existing files / folders
        /// </summary>
        /// <remarks>
        /// Optional. "true": overwrite all existing files with the same name; "false": skip all existing files with the same name; (None): do not overwrite or skip existed files. If there is any existing files, an error occurs (error code: 1003).
        /// </remarks>
        public bool? Overwrite { get; set; }

        /// <summary>
        /// Mark the operation as a move operation
        /// </summary>
        /// <remarks>
        /// Optional. "true": move filess/folders; "false": copy files/folders
        /// </remarks>
        [JsonProperty("remove_src")]
        public bool Move { get; set; }

        /// <summary>
        /// Precision of the progress calculation
        /// </summary>
        /// <remarks>
        /// Optional. "true": calculate the progress by each moved/copied file within subfolder. "false": calculate the progress by files which you give in path parameters. This calculates the progress faster, but is less precise.
        /// </remarks>
        [JsonProperty("accurate_progress")]
        public bool AccurateProgress { get; set; }

        /// <summary>
        /// Search Id from which the files are to be copied / move
        /// </summary>
        /// <remarks>
        /// Optional. A unique ID for the search task which is gotten from SYNO.FileSation.Search API with start method. This is used to update the search result.
        /// </remarks>
        [JsonProperty("search_taskid")]
        public string SearchTaskId { get; set; }

        public override QueryStringParameter[] Parameters()
        {
            return new[]
            {
                new QueryStringParameter("path", $"({string.Join(",", Path)})"),
                new QueryStringParameter("dest_folder_path", DestinationFolder),
                new QueryStringParameter("overwrite", Overwrite),
                new QueryStringParameter("remove_src", Move),
                new QueryStringParameter("accurate_progress", AccurateProgress),
                new QueryStringParameter("search_taskid", SearchTaskId),
            };
        }
    }
}
