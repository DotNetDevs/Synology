using Synology.Classes;

namespace Synology.Api
{
	public abstract class MainApiRequest : ApiRequest
	{
		protected MainApiRequest(SynologyConnection connection, string cgiPath, string api) : base(connection, cgiPath, $"API.{api}")
		{
		}
	}
}