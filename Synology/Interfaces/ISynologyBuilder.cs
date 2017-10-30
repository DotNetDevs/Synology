using System;
namespace Synology.Interfaces
{
    public interface ISynologyBuilder
    {
        void AddApi();
        void AddAudioStation();
        void AddDownloadStation();
        void AddDownloadStation2();
        void AddFileStation();
        void AddSurveillanceStation();
        void AddVideoStation();
    }
}
