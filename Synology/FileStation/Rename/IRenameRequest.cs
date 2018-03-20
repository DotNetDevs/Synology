using Synology.Classes;
using Synology.FileStation.Rename.Parameters;
using Synology.FileStation.Rename.Results;
using Synology.Interfaces;

namespace Synology.FileStation.Rename
{
    /// <summary>
    /// Rename request.
    /// </summary>
    public interface IRenameRequest : ISynologyRequest
    {
        /// <summary>
        /// Rename a file/folder
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        ResultData<FileResult> Rename(RenameParameters parameters);
    }
}