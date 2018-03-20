using Synology.Parameters;
using System.ComponentModel.DataAnnotations;
using Synology.Utilities;

namespace Synology.FileStation.List.Parameters
{
    /// <summary>
    /// Get file info parameters.
    /// </summary>
    public class GetFileInfoParameters : RequestParameters
    {
        /// <summary>
        /// One or more folder/file path(s) started with a shared folder, separated by a comma, “,” and around backets.
        /// </summary>
        [Required]
        public string Path { get; set; }

        /// <summary>
        /// Optional. Additional requested file information, separated by a comma “,“ and around the brackets.When an additional option is requested, responded objects will be provided in the specified additional option.
        /// </summary>
        public FileDetailsType Additional { get;set;}

        /// <summary>
        /// Parameters this instance.
        /// </summary>
        /// <returns>The parameters.</returns>
        public override QueryStringParameter[] Parameters()
        {
            return new[]
            {
                new QueryStringParameter("path", Path),
                new QueryStringParameter("additional", Additional),
            };
        }
    }
}
