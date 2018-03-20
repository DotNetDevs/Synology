using Newtonsoft.Json;
using Synology.Utilities;
using System.ComponentModel.DataAnnotations;
using Synology.Parameters;

namespace Synology.FileStation.CheckPermission.Parameters
{
    /// <summary>
    /// Check permission write parameters.
    /// </summary>
	public class CheckPermissionWriteParameters : RequestParameters
	{
        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>The path.</value>
		[Required]
		public string Path { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this
        /// <see cref="T:Synology.FileStation.CheckPermission.Parameters.CheckPermissionWriteParameters"/> create only.
        /// </summary>
        /// <value><c>true</c> if create only; otherwise, <c>false</c>.</value>
		[Required]
		[JsonProperty("create_only")]
		public bool CreateOnly { get; set; }

        /// <summary>
        /// Parameters this instance.
        /// </summary>
        /// <returns>The parameters.</returns>
		public override QueryStringParameter[] Parameters()
		{
			return new[] {
				new QueryStringParameter("path", Path),
				new QueryStringParameter("create_only", CreateOnly)
			};
		}
	}
}

