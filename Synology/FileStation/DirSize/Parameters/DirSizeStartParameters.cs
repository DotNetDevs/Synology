using Synology.Parameters;
using Synology.Utilities;
using System.ComponentModel.DataAnnotations;
namespace Synology.FileStation.DirSize.Parameters
{
    /// <summary>
    /// Dir size start parameters.
    /// </summary>
	public class DirSizeStartParameters : RequestParameters
	{
        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>The path.</value>
		[Required]
		public string Path { get; set; }

        /// <summary>
        /// Parameters this instance.
        /// </summary>
        /// <returns>The parameters.</returns>
		public override QueryStringParameter[] Parameters()
		{
			return new[] {
				new QueryStringParameter("path", Path)
			};
		}
	}
}

