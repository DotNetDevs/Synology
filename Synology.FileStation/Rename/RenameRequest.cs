using Synology.Classes;
using Synology.FileStation.FileShare.Results;
using Synology.FileStation.Rename.Parameters;
using Synology.Parameters;

namespace Synology.FileStation.Rename
{
    public class RenameRequest : SynologyRequest
    {
        public RenameRequest(SynologyApi api) : base(api, "entry.cgi", "FileStation.Rename")
        {
        }

        /// <summary>
        /// Rename a file/folder
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public ResultData<FileResult> Rename(RenameParameters parameters)
        {
            return GetData<FileResult>(new SynologyRequestParameters
            {
                Version = 2,
                Method = "rename",
                Additional = parameters
            });
        }
    }
}
