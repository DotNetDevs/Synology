using Synology.Classes;
using Synology.FileStation.Info.Results;
using Synology.Interfaces;

namespace Synology.FileStation.Info
{
    /// <summary>
    /// Info request.
    /// </summary>
    public interface IInfoRequest : ISynologyRequest
    {
        /// <summary>
        /// Get this instance.
        /// </summary>
        /// <returns>The get.</returns>
        ResultData<InfoResult> Get();
    }
}
