using Synology.Classes;
using Synology.DownloadStation.Info.Parameters;
using Synology.DownloadStation.Info.Results;
using Synology.Interfaces;

namespace Synology.DownloadStation.Info
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

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		ResultData<ConfigResult> Config();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
		ResultData SetConfig(SetConfigParameters parameters);
	}
}
