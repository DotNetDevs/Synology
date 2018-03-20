using Synology.Utilities;
using System.ComponentModel.DataAnnotations;
using Synology.Parameters;

namespace Synology.FileStation.Favorite.Parameters
{
    /// <summary>
    /// Favorite delete parameters.
    /// </summary>
	public class FavoriteDeleteParameters : RequestParameters
	{
        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>The path.</value>
		[Required]
		public string Path { get; set; }

        /// <summary>
        /// sParameters this instance.
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

