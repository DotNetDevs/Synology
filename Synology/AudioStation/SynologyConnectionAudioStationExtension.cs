using Synology;
using Synology.AudioStation;
using Synology.Interfaces;

namespace Synology
{
	/// <summary>
	/// 
	/// </summary>
	public static class SynologyConnectionAudioStationExtension
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="connection"></param>
		/// <returns></returns>
		public static IAudioStationApi AudioStation(this ISynologyConnection connection) => connection.Api<IAudioStationApi>();
	}
}