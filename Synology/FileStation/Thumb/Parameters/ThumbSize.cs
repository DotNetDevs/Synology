using System.ComponentModel;

namespace Synology.FileStation.Thumb.Parameters
{
    /// <summary>
    /// Thumb size.
    /// </summary>
	public enum ThumbSize
	{
        /// <summary>
        /// The small.
        /// </summary>
		[Description("small")]
		Small,

        /// <summary>
        /// The medium.
        /// </summary>
		[Description("medium")]
		Medium,

        /// <summary>
        /// The large.
        /// </summary>
		[Description("large")]
		Large,

        /// <summary>
        /// The original.
        /// </summary>
		[Description("original")]
		Original
	}
}

