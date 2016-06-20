using Synology.Attributes;
using Synology.Classes;

namespace Synology.SurveillanceStation
{
    [Request("SurveillanceStation")]
    public abstract class SurveillanceStationRequest : SynologyRequest
	{
		protected SurveillanceStationRequest(SynologyApi parentApi, string cgiPath, string api) : base(parentApi, $"SurveillanceStation/{cgiPath}", $"SurveillanceStation.{api}")
		{
		}
	}
}