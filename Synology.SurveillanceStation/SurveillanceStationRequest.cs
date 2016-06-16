using Synology.Classes;

namespace Synology.SurveillanceStation
{
	public abstract class SurveillanceStationRequest : SynologyRequest
	{
		protected SurveillanceStationRequest(SynologyApi parentApi, string cgiPath, string api) : base(parentApi, $"SurveillanceStation/{cgiPath}", $"SurveillanceStation.{api}")
		{
		}
	}
}