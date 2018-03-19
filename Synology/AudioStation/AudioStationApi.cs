using Synology.Classes;
using Synology.Interfaces;

namespace Synology.AudioStation
{
	/// <inheritdoc cref="SynologyApi" />
	/// <summary>
	/// </summary>
	internal class AudioStationApi : SynologyApi, IAudioStationApi
	{
		/// <inheritdoc />
		/// <summary>
		/// </summary>
		/// <param name="connection"></param>
		public AudioStationApi(ISynologyConnection connection) : base(connection)
		{
		}
	}
}