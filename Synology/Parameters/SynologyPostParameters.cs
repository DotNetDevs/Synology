using Synology.Utilities;
using Synology.Classes;
using System.Runtime.CompilerServices;

namespace Synology.Parameters
{
	/// <summary>
	/// Parameters used for post requests
	/// </summary>
	public class SynologyPostParameters : SynologyParameters<FormParameter>
	{
        public SynologyPostParameters(SynologyRequest request, [CallerMemberName] string methodName = null) : base(request, methodName)
		{
		}
	}
}
