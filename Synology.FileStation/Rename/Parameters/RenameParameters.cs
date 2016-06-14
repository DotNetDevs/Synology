using System.Collections.Generic;
using Synology.Utilities;
using System.ComponentModel.DataAnnotations;
using Synology.Parameters;

namespace Synology.FileStation.Rename.Parameters
{
    public class RenameParameters : RequestParameters
    {
        /// <summary>
        /// One or more file or folder path to rename
        /// </summary>
        /// <remarks>
        /// One or more paths of files/folders to be renamed, separated by commas "," and around brackets.The number of paths must be the same as the number of names in the name parameter.The first path parameter corresponds to the first name parameter.
        /// </remarks>
        [Required]
        public IEnumerable<string> Path { get; set; }

        /// <summary>
        /// One or more new names
        /// </summary>
        /// <remarks>
        /// One or more new names, separated by commas "," and around brackets. The number of names must be the same as the number of folder paths in the path parameter.The first name parameter corresponding to the first path parameter.
        /// </remarks>
        [Required]
        public IEnumerable<string> Name { get; set; }

        /// <summary>
        /// Additional informations to be retrieved
        /// </summary>
        /// <remarks>
        /// Optional. Additional requested file information, separated by commas "," and around brackets. When an additional option is requested, responded objects will be provided in the specified additional option.
        /// </remarks>
        public RenameAdditional Additional { get; set; }

        /// <summary>
        /// The search task id to be updated by the rename
        /// </summary>
        /// <remarks>
        /// Optional. A unique ID for the search task which is obtained from start method.It is used to update the renamed file in the search result.
        /// </remarks>
        public string SearchTaskId { get; set; }

        public override QueryStringParameter[] Parameters()
        {
            return new[]
            {
                new QueryStringParameter("path", Path, true),
                new QueryStringParameter("name", Name, true),
                new QueryStringParameter("additional", Additional, true),
                new QueryStringParameter("search_taskid", SearchTaskId),
            };
        }
    }
}
