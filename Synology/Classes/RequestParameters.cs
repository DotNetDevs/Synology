using System;
using Synology.Utilities;

namespace Synology.Classes
{
	public abstract class RequestParameters
	{
		public abstract QueryStringParameter[] Parameters();

		public static implicit operator QueryStringParameter[](RequestParameters parameters)
		{
			return parameters?.Parameters();
		}
	}
}

