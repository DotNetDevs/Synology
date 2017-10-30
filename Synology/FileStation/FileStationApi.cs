using Synology.Classes;
using Synology.Interfaces;

namespace Synology.FileStation
{
    class FileStationApi : SynologyApi, IFileStationApi
	{
		public FileStationApi(ISynologyConnection connection) : base(connection)
		{
		}
	}
}