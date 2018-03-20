using System.Runtime.CompilerServices;
using Synology.Interfaces;
using Synology.Utilities;

namespace Synology.Parameters
{
    /// <summary>
    /// Synology request parameters.
    /// </summary>
	public class SynologyRequestParameters : SynologyParameters<QueryStringParameter>
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Synology.Parameters.SynologyRequestParameters"/> class.
        /// </summary>
        /// <param name="request">Request.</param>
        /// <param name="methodName">Method name.</param>
        public SynologyRequestParameters(ISynologyRequest request, [CallerMemberName] string methodName = null) : base(request, methodName)
		{
		}
	}
}
