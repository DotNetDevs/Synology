using Synology.Attributes;
using Synology.Classes;
using Synology.FileStation.Rename.Results;
using Synology.FileStation.Rename.Parameters;
using Synology.Parameters;

namespace Synology.FileStation.Rename
{
	[Request("Rename")]
	internal class RenameRequest : FileStationRequest, IRenameRequest
	{
        public RenameRequest(IFileStationApi api) : base(api)
		{
		}

		/// <summary>
		/// Rename a file/folder
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
		[RequestMethod("rename")]
		public ResultData<FileResult> Rename(RenameParameters parameters)
		{
			return GetData<FileResult>(new SynologyRequestParameters(this)
			{
				Version = 2,
				Additional = parameters
			});
		}
	}
}
