using System;
using Synology.Api.Auth.Parameters;
using Synology.Api.Auth.Results;
using Synology.Attributes;
using Synology.Classes;
using Synology.Interfaces;

namespace Synology.Api.Auth
{
    public interface IAuthRequest : ISynologyRequest
    {
        ResultData<AuthResult> Login(LoginParameters parameters = null);

        ResultData Logout();
    }
}
