using Synology.Attributes;
using Synology.Classes;
using Synology.FileStation.Rename.Results;
using Synology.FileStation.Rename.Parameters;
using Synology.Parameters;
using System;
using System.Threading.Tasks;

namespace Synology.FileStation.Rename
{
	[Request("Rename")]
	internal class RenameRequest : FileStationRequest, IRenameRequest
	{
        public RenameRequest(IFileStationApi api) : base(api)
		{
		}

        /// <summary>
        /// Renames the async.
        /// </summary>
        /// <returns>The async.</returns>
        /// <param name="parameters">Parameters.</param>
        [RequestMethod("rename")]
        public async Task<ResultData<FileResult>> RenameAsync(RenameParameters parameters)
        {
            return await this.GetDataAsync<FileResult>(new SynologyRequestParameters(this)
            {
                Version = 2,
                Additional = parameters
            });
        }
	}
}
