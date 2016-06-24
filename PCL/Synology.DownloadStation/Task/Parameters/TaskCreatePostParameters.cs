using Synology.Classes;
using System;
using System.Collections.Generic;
using Synology.Utilities;

namespace Synology.DownloadStation.Task.Parameters
{
    /// <summary>
    /// Parameters of the TaskEx Create method
    /// </summary>
    public class TaskCreatePostParameters : PostParameters
    {
        /// <summary>
        /// The file data
        /// </summary>
        public byte[] File { get; set; }
        /// <summary>
        /// The File name
        /// </summary>
        public string Filename { get; set; }
        /// <summary>
        /// The destination where the files are to be downloaded (starting with a Shared Folder)
        /// </summary>
        /// <example>
        /// /SharedDownloads/Documents
        /// </example>
        public string Destination { get; set; }
        /// <summary>
        /// Create list parameter
        /// </summary>
        public bool CreateList { get; set; }

        /// <summary>
        /// Get the parameters as a FormParameter array
        /// </summary>
        /// <returns></returns>
        public override FormParameter[] Parameters()
        {
            var fileCondition = new Random().Next();

            var parameters = new List<FormParameter>
            {
                new FormParameter("file", $"[\"{fileCondition}\"]"),
                new FormParameter("type", "\"file\""),
                new FormParameter("create_list", $"{CreateList.ToString().ToLowerInvariant()}"),
                new FormParameter("destination", $"\"{Destination}\""),
                // From the documentation, the file must always be the last parameter
                new FileFormDataParameter(fileCondition.ToString(), Filename, File)
            };

            return parameters.ToArray();
        }
    }
}
