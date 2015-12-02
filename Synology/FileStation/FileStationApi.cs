using Synology.Classes;
using Synology.FileStation.Search;
using Synology.FileStation.Info;
using Synology.FileStation.FileShare;

namespace Synology.FileStation
{
	public class FileStationApi : SynologyApi
	{
		public FileStationApi(SynologyConnection connection) : base(connection)
		{
			RegisterRequest<FileShareRequest>();
			RegisterRequest<InfoRequest>();
			RegisterRequest<SearchRequest>();
		}
	}
}