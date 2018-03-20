using Synology.Utilities;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Synology.Parameters;

namespace Synology.FileStation.MD5.Parameters
{
    /// <summary>
    /// MD 5 start parameters.
    /// </summary>
	public class MD5StartParameters : RequestParameters
	{
        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        /// <value>The file path.</value>
		[Required]
		[JsonProperty("file_path")]
		public string FilePath { get; set; }

        /// <summary>
        /// Parameters this instance.
        /// </summary>
        /// <returns>The parameters.</returns>
		public override QueryStringParameter[] Parameters()
		{
			return new[] {
				new QueryStringParameter("file_path", FilePath)
			};
		}
	}
}

