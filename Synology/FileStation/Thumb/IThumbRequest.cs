using Synology.Classes;
using Synology.FileStation.Thumb.Parameters;
using Synology.Interfaces;

namespace Synology.FileStation.Thumb
{
    public interface IThumbRequest : ISynologyRequest
    {
        ResultData<byte[]> Get(ThumbGetParameters parameters);
    }
}