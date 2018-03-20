using Synology.Api;
using Synology.Api.Auth;

namespace Synology
{
	/// <summary>
	/// 
	/// </summary>
	public static class ApiAuthExtension
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="api"></param>
		/// <returns></returns>
		public static IAuthRequest Auth(this IApi api)
		{
			return api.Request<IAuthRequest>();
		}
	}
}