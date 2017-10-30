using Synology.Classes;
using Synology.Interfaces;

namespace Synology.DownloadStation2
{
	public class DownloadStation2Api : SynologyApi, IDownloadStation2Api
	{
		public DownloadStation2Api(ISynologyConnection connection) : base(connection)
		{
		}
	}
}