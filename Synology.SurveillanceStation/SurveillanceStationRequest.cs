using Synology.Attributes;
using Synology.Classes;

namespace Synology.SurveillanceStation
{
    [Request("SurveillanceStation")]
    public abstract class SurveillanceStationRequest : SynologyRequest
	{
		protected SurveillanceStationRequest(SynologyApi parentApi) : base(parentApi)
		{
		}
	}
}