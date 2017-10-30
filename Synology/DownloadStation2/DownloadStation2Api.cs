using Synology.Classes;
using Synology.Interfaces;

namespace Synology.DownloadStation2
{
	/// <inheritdoc cref="SynologyApi" />
	/// <summary>
	/// </summary>
	public class DownloadStation2Api : SynologyApi, IDownloadStation2Api
	{
		/// <inheritdoc />
		/// <summary>
		/// </summary>
		/// <param name="connection"></param>
		public DownloadStation2Api(ISynologyConnection connection) : base(connection)
		{
		}
	}
}