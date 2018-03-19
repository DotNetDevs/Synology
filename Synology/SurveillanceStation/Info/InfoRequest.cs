using Synology.Attributes;
using Synology.Classes;
using Synology.SurveillanceStation.Info.Results;
using Synology.Parameters;

namespace Synology.SurveillanceStation.Info
{
	/// <inheritdoc cref="SurveillanceStationRequest" />
	/// <summary>
	/// </summary>
	[Request("Info")]
	internal class InfoRequest : SurveillanceStationRequest, IInfoRequest
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="api"></param>
		public InfoRequest(ISurveillanceStationApi api) : base(api)
		{
		}

		/// <inheritdoc />
		/// <summary>
		/// </summary>
		/// <returns></returns>
		[RequestMethod("getinfo")]
		public ResultData<InfoResult> GetInfo()
		{
			return GetData<InfoResult>(new SynologyRequestParameters(this));
		}
	}
}
