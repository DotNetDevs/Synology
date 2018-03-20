namespace Synology.Interfaces
{
    /// <summary>
    /// Synology builder.
    /// </summary>
    public interface ISynologyBuilder
    {
        /// <summary>
        /// Adds the API.
        /// </summary>
        /// <returns>The API.</returns>
        ISynologyBuilder AddApi();

        /// <summary>
        /// Adds the audio station.
        /// </summary>
        /// <returns>The audio station.</returns>
        ISynologyBuilder AddAudioStation();

        /// <summary>
        /// Adds the download station.
        /// </summary>
        /// <returns>The download station.</returns>
        ISynologyBuilder AddDownloadStation();

        /// <summary>
        /// Adds the download station2.
        /// </summary>
        /// <returns>The download station2.</returns>
        ISynologyBuilder AddDownloadStation2();

        /// <summary>
        /// Adds the file station.
        /// </summary>
        /// <returns>The file station.</returns>
        ISynologyBuilder AddFileStation();

        /// <summary>
        /// Adds the surveillance station.
        /// </summary>
        /// <returns>The surveillance station.</returns>
        ISynologyBuilder AddSurveillanceStation();

        /// <summary>
        /// Adds the video station.
        /// </summary>
        /// <returns>The video station.</returns>
        ISynologyBuilder AddVideoStation();
    }
}
