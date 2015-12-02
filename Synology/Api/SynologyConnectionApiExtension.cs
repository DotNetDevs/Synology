namespace Synology
{
	public static class SynologyConnectionApiExtension
	{
		private static Api.Api _api;

		public static Api.Api Api(this SynologyConnection connection)
		{
			return _api ?? (_api = connection.GetApi<Api.Api>());
		}
	}
}