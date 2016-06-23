using Synology.Classes;
using Synology.Utilities;

namespace Synology.Parameters
{
	public class SynologyRequestParameters : SynologyParameters<QueryStringParameter>
	{
		public SynologyRequestParameters(SynologyRequest request) : base(request)
		{
		}
	}
}
