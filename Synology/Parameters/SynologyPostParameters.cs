using Synology.Utilities;
using System.Runtime.CompilerServices;
using Synology.Interfaces;

namespace Synology.Parameters
{
	/// <summary>
	/// Parameters used for post requests
	/// </summary>
	public class SynologyPostParameters : SynologyParameters<FormParameter>
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Synology.Parameters.SynologyPostParameters"/> class.
        /// </summary>
        /// <param name="request">Request.</param>
        /// <param name="methodName">Method name.</param>
        public SynologyPostParameters(ISynologyRequest request, [CallerMemberName] string methodName = null) : base(request, methodName)
		{
		}
	}
}
