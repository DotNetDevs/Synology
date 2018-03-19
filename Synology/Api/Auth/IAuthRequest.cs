using Synology.Api.Auth.Parameters;
using Synology.Api.Auth.Results;
using Synology.Classes;
using Synology.Interfaces;

namespace Synology.Api.Auth
{
	/// <summary>
	/// 
	/// </summary>
	public interface IAuthRequest : ISynologyRequest
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
		ResultData<AuthResult> Login(LoginParameters parameters = null);

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		ResultData Logout();
	}
}
