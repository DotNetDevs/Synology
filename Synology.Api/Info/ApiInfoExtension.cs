using Synology.Api.Info;

namespace Synology
{
	public static class ApiInfoExtension
	{
		private static InfoRequest _info;

		public static InfoRequest Info(this Api.Api api)
		{
			if (_info == null)
			{
				api.RegisterRequest<InfoRequest>();
				_info = api.GetRequest<InfoRequest>();
			}

			return _info;
		}
	}
}

