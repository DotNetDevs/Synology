using Synology.Classes;
using Synology.Api.Auth;
using Synology.Api.Info;

namespace Synology.Api
{
	public class Api : SynologyApi
	{
		public Api(SynologyConnection connection) : base(connection)
		{
			RegisterRequest<AuthRequest>();
			RegisterRequest<InfoRequest>();
		}
	}
}