using Synology.Extensions;

namespace Synology
{
	public static class SynologyConnectionApiExtension
	{
		public static Api.Api Api(this SynologyConnection connection)
		{
			return ApiExtension<Api.Api>.Api(connection);
		}
	}
}