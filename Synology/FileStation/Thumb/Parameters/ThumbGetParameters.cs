using Synology.Utilities;
using System.ComponentModel.DataAnnotations;
using Synology.Parameters;

namespace Synology.FileStation.Thumb.Parameters
{
    /// <summary>
    /// Thumb get parameters.
    /// </summary>
	public class ThumbGetParameters : RequestParameters
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Synology.FileStation.Thumb.Parameters.ThumbGetParameters"/> class.
        /// </summary>
		public ThumbGetParameters()
		{
			Size = ThumbSize.Small;
			Rotate = ThumbRotation.Original;
		}

        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>The path.</value>
		[Required]
		public string Path { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>The size.</value>
		public ThumbSize Size { get; set; }

        /// <summary>
        /// Gets or sets the rotate.
        /// </summary>
        /// <value>The rotate.</value>
		public ThumbRotation Rotate { get; set; }

        /// <summary>
        /// Parameters this instance.
        /// </summary>
        /// <returns>The parameters.</returns>
		public override QueryStringParameter[] Parameters()
		{
			return new[] {
				new QueryStringParameter("path", Path),
				new QueryStringParameter("size", Size),
				new QueryStringParameter("rotate", (int)Rotate)
			};
		}
	}
}

