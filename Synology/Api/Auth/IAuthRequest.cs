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
        /// Logins the async.
        /// </summary>
        /// <returns>The async.</returns>
        /// <param name="parameters">Parameters.</param>
        Task<ResultData<IAuthResult>> LoginAsync(LoginParameters parameters = null);

        /// <summary>
        /// Logouts the async.
        /// </summary>
        /// <returns>The async.</returns>
        Task<ResultData> LogoutAsync();
    }
}
