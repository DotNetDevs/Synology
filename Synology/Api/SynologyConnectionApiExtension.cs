using Synology.Api;
using Synology.Extensions;
using Synology.Interfaces;

namespace Synology
{
	/// <summary>
	/// 
	/// </summary>
	public static class SynologyConnectionApiExtension
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="connection"></param>
		/// <returns></returns>
		public static IApi Api(this ISynologyConnection connection) => connection.Api<IApi>();
	}
}