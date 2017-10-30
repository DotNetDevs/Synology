using Synology.Attributes;
using Synology.Classes;
using Synology.Interfaces;

namespace Synology.SurveillanceStation
{
    [Request("SurveillanceStation")]
    internal abstract class SurveillanceStationRequest : SynologyRequest
	{
        protected SurveillanceStationRequest(ISurveillanceStationApi parentApi) : base(parentApi)
		{
		}
	}
}