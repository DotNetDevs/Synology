using System;
using System.Threading.Tasks;
using Synology.Api.Auth.Parameters;
using Synology.Api.Auth.Results;
using Synology.Classes;
using Synology.Interfaces;

namespace Synology.Api.Auth
{
	/// <summary>
    /// Auth request.
    /// </summary>
	public interface IAuthRequest : ISynologyRequest
	{
		/// <summary>
        /// Login the specified parameters.
        /// </summary>
        /// <returns>The login.</returns>
        /// <param name="parameters">Parameters.</param>
        [Obsolete("It uses Result, migrate to Async methods")]
		ResultData<IAuthResult> Login(LoginParameters parameters = null);

        /// <summary>
        /// Logins the async.
        /// </summary>
        /// <returns>The async.</returns>
        /// <param name="parameters">Parameters.</param>
        Task<ResultData<IAuthResult>> LoginAsync(LoginParameters parameters = null);

		/// <summary>
        /// Logout this instance.
        /// </summary>
        /// <returns>The logout.</returns>
        [Obsolete("It uses Result, migrate to Async methods")]
		ResultData Logout();

        /// <summary>
        /// Logouts the async.
        /// </summary>
        /// <returns>The async.</returns>
        Task<ResultData> LogoutAsync();
	}
}
