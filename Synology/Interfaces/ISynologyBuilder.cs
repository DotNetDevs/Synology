namespace Synology.Interfaces
{
    public interface ISynologyBuilder
    {
        ISynologyBuilder AddApi();
        ISynologyBuilder AddAudioStation();
        ISynologyBuilder AddDownloadStation();
        ISynologyBuilder AddDownloadStation2();
        ISynologyBuilder AddFileStation();
        ISynologyBuilder AddSurveillanceStation();
        ISynologyBuilder AddVideoStation();
    }
}
