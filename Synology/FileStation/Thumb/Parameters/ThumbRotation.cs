namespace Synology.FileStation.Thumb.Parameters
{
    /// <summary>
    /// Thumb rotation.
    /// </summary>
	public enum ThumbRotation
	{
        /// <summary>
        /// 0°
        /// </summary>
		Original = 0,
        /// <summary>
        /// 90°
        /// </summary>
		RotateRight = 1,
        /// <summary>
        /// 180°
        /// </summary>
		FlipHorizontal = 2,
        /// <summary>
        /// 270°
        /// </summary>
		RotateLeft = 3,
        /// <summary>
        /// 360°
        /// </summary>
		RotateFull = 4
	}
}

