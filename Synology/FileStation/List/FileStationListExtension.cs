using Synology.FileStation;
using Synology;
using Synology.FileStation.List;

namespace Synology
{
	public static class FileStationListExtension
	{
		public static IListRequest List(this IFileStationApi api)
		{
			return api.Request<IListRequest>();
		}
	}
}

