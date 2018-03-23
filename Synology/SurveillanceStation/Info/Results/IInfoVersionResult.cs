namespace Synology.SurveillanceStation.Info.Results
{
    /// <summary>
    /// Info version result.
    /// </summary>
    public interface IInfoVersionResult
    {
        /// <summary>
        /// Gets the major.
        /// </summary>
        /// <value>The major.</value>
        int Major { get; }
        /// <summary>
        /// Gets the minor.
        /// </summary>
        /// <value>The minor.</value>
        int Minor { get; }
        /// <summary>
        /// Gets the build.
        /// </summary>
        /// <value>The build.</value>
        int Build { get; }
    }
}