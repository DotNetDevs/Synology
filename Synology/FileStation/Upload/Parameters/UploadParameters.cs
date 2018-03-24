using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Synology.Utilities;
using Synology.Parameters;

namespace Synology.FileStation.Upload.Parameters
{
    /// <summary>
    /// Upload parameters.
    /// </summary>
    public class UploadParameters : PostParameters
    {
        /// <summary>
        /// Destination of the file (starting with a shared folder)
        /// </summary>
        /// <example>
        /// /Uploads
        /// </example>
        [Required]
        public string DestinationPath { get; set; }

        /// <summary>
        /// Create the parent folder if non existing
        /// </summary>
        [Required]
        public bool CreateParents { get; set; }

        /// <summary>
        /// Name of the file to upload
        /// </summary>
        [Required]
        public string FileName { get; set; }

        /// <summary>
        /// Data of the file to upload
        /// </summary>
        [Required]
        public byte[] FileData { get; set; }

        /// <summary>
        /// Overwrite the file if existing
        /// </summary>
        public bool? Overwrite { get; set; }

        /// <summary>
        /// Overwrite the last modified date of the file
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Overwrite the created date of the file
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Overwrite the last access time of the file
        /// </summary>
        public DateTime? LastAccessTime { get; set; }

        /// <summary>
        /// Get the parameters as a FormParameter array
        /// </summary>
        /// <returns></returns>
        public override FormParameter[] Parameters()
        {
            var parameters = new List<FormParameter>
            {
                new FormParameter("path", DestinationPath),
                new FormParameter("create_parents", CreateParents),
                new FormParameter("overwrite", Overwrite.HasValue ? Overwrite.ToString().ToLowerInvariant() : "(None)"),
            };

            if(LastModifiedTime.HasValue)
            {
                parameters.Add(new FormParameter("mtime", LastModifiedTime.Value));
            }

            if (CreatedTime.HasValue)
            {
                parameters.Add(new FormParameter("crtime", CreatedTime.Value));
            }

            if (LastAccessTime.HasValue)
            {
                parameters.Add(new FormParameter("atime", LastAccessTime.Value));
            }

            parameters.Add(new FormParameter("size", FileData.Length));

            // From the documentation, the file must always be the last parameter
            parameters.Add(new FileFormDataParameter("file", FileName, FileData));

            return parameters.ToArray();
        }
    }
}
