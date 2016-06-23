using Synology.Utilities;
using Synology.Classes;

namespace Synology.Parameters
{
	/// <summary>
	/// Parameters used for post requests
	/// </summary>
	public class SynologyPostParameters : SynologyParameters<FormParameter>
	{
		public SynologyPostParameters(SynologyRequest request) : base(request)
		{
		}
	}
}
