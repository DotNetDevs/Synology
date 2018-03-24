using Synology;
using Synology.Api;
using Synology.Api.Info;

namespace Synology
{
	/// <summary>
	/// 
	/// </summary>
	public static class ApiInfoExtension
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="api"></param>
		/// <returns></returns>
		public static IInfoRequest Info(this IApi api) => api.Request<IInfoRequest>();
	}
}

