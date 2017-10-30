using Synology.Classes;
using Synology.Interfaces;

namespace Synology.SurveillanceStation
{
	/// <inheritdoc cref="SynologyApi" />
	/// <summary>
	/// </summary>
	internal class SurveillanceStationApi : SynologyApi, ISurveillanceStationApi
	{
		/// <inheritdoc />
		/// <summary>
		/// </summary>
		/// <param name="connection"></param>
		public SurveillanceStationApi(ISynologyConnection connection) : base(connection)
		{
		}
	}
}