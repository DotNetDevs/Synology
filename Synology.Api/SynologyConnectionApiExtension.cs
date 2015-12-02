namespace Synology
{
	public static class SynologyConnectionApiExtension
	{
		private static Api.Api _api;

		public static Api.Api Api(this SynologyConnection connection)
		{
			if (_api == null)
			{
				connection.RegisterApi<Api.Api>();
				_api = connection.GetApi<Api.Api>();
			}

			return _api;
		}
	}
}