namespace Synology.Api
{
	public static class SynologyConnectionExtension
	{
		private static Api _api;
		public static Api Api(this SynologyConnection connection)
		{
			return _api ?? (_api = connection.GetApi<Api>());
		}
	}
}
