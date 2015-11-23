using Synology.Auth;
using Synology.Info;

namespace Synology.Apis
{
	public class Api : BaseApi
	{
		internal Api(SynologyConnection connection) : base(connection)
		{
			Auth = new AuthRequest(connection);
			Info = new InfoRequest(connection);
		}

		public AuthRequest Auth { get; private set; }

		public InfoRequest Info { get; private set; }
	}
}