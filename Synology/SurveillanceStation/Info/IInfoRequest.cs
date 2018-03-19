using Synology.Classes;
using Synology.Interfaces;
using Synology.SurveillanceStation.Info.Results;

namespace Synology.SurveillanceStation.Info
{
	/// <inheritdoc />
	/// <summary>
	/// </summary>
	public interface IInfoRequest : ISynologyRequest
	{
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		ResultData<InfoResult> GetInfo();
	}
}
