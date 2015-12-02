using Synology.Api.Info;

namespace Synology
{
	public static class ApiInfoExtension
	{
		private static InfoRequest _info;

		public static InfoRequest Info(this Api.Api api)
		{
			return _info ?? (_info = api.GetRequest<InfoRequest>());
		}
	}
}

