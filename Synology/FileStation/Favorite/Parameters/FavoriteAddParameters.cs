using Synology.Utilities;
using System.ComponentModel.DataAnnotations;
using Synology.Parameters;

namespace Synology.FileStation.Favorite.Parameters
{
    /// <summary>
    /// Favorite add parameters.
    /// </summary>
	public class FavoriteAddParameters : RequestParameters
	{
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Synology.FileStation.Favorite.Parameters.FavoriteAddParameters"/> class.
        /// </summary>
		public FavoriteAddParameters()
		{
			Index = -1;
		}

        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>The path.</value>
		[Required]
		public string Path { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
		[Required]
		public string Name { get; set; }

        /// <summary>
        /// Gets or sets the index.
        /// </summary>
        /// <value>The index.</value>
		public int Index { get; set; }

        /// <summary>
        /// Parameters this instance.
        /// </summary>
        /// <returns>The parameters.</returns>
		public override QueryStringParameter[] Parameters()
		{
			return new[] {
				new QueryStringParameter("path", Path),
				new QueryStringParameter("name", Name),
				new QueryStringParameter("index", Index)
			};
		}
	}
}

