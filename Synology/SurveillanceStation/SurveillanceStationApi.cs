using Synology.Classes;
using Synology.Interfaces;

namespace Synology.SurveillanceStation
{
	public class SurveillanceStationApi : SynologyApi, ISurveillanceStationApi
	{
		public SurveillanceStationApi(ISynologyConnection connection) : base(connection)
		{
		}
	}
}