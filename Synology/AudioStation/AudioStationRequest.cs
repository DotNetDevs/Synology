using Synology.Attributes;
using Synology.Classes;

namespace Synology.AudioStation
{
	/// <summary>
	/// 
	/// </summary>
	[Request("AudioStation")]
	internal abstract class AudioStationRequest : SynologyRequest
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="parentApi"></param>
		protected AudioStationRequest(IAudioStationApi parentApi) : base(parentApi)
		{
		}
	}
}