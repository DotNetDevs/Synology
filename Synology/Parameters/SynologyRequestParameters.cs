using System.Runtime.CompilerServices;
using Synology.Classes;
using Synology.Interfaces;
using Synology.Utilities;

namespace Synology.Parameters
{
	public class SynologyRequestParameters : SynologyParameters<QueryStringParameter>
	{
        public SynologyRequestParameters(ISynologyRequest request, [CallerMemberName] string methodName = null) : base(request, methodName)
		{
		}
	}
}
