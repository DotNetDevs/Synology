using System;
using Synology;
using Synology.Api.Info;

namespace Synology.Api
{
	public static class ApiInfoExtension
	{
		private static InfoRequest _info;

		public static InfoRequest Info(this Api api)
		{
			return _info ?? (_info = api.GetRequest<InfoRequest>());
		}
	}
}

