using Synology.Classes;
using Synology.FileStation.Search;
using Synology.FileStation.Info;
using Synology.FileStation.FileShare;
using Synology.Interfaces;

namespace Synology.FileStation
{
	public class FileStationApi : SynologyApi, IFileStationApi
	{
		public FileStationApi(ISynologyConnection connection) : base(connection)
		{
		}
	}
}