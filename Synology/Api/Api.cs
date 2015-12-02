using Synology.Classes;

namespace Synology.Api
{
	public class Api : SynologyApi
	{
		public Api(SynologyConnection connection) : base(connection)
		{
			RegisterRequest<AuthRequest>();
			RegisterRequest<InfoRequest>();

			Auth = ResolveRequest<AuthRequest>();
			Info = ResolveRequest<InfoRequest>();
		}

		public AuthRequest Auth { get; private set; }

		public InfoRequest Info { get; private set; }
	}
}