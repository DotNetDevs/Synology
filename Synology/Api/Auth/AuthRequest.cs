﻿using Synology.Classes;
using Synology.Utilities;
using Synology.Api.Auth.Parameters;
using Synology.Api.Auth.Results;
using Synology.Attributes;
using Synology.Parameters;
using Synology.Extensions;

namespace Synology.Api.Auth
{
    [Request("Auth")]
    internal sealed class AuthRequest : MainApiRequest, IAuthRequest
    {
        private string _sessionNumber;

        public AuthRequest(IApi api) : base(api)
        {
        }

        [RequestMethod("login")]
        public ResultData<AuthResult> Login(LoginParameters parameters = null)
        {
            parameters = parameters ?? new LoginParameters
            {
                Username = Api.Connection.Settings.Username,
                Password = Api.Connection.Settings.Password
            };

            _sessionNumber = parameters.SessionName;

            var result = GetData<AuthResult>(new SynologyRequestParameters(this)
            {
                Version = 4,
                Additional = parameters
            });

            if (result.Success && !string.IsNullOrWhiteSpace(result.Data?.Sid))
                Api.Connection.SetSid(result.Data?.Sid);

            return result;
        }

        [RequestMethod("logout")]
        public ResultData Logout()
        {
            var parameters = new[] {
                new QueryStringParameter("session", _sessionNumber),
            };

            var result = GetData(new SynologyRequestParameters(this)
            {
                Additional = parameters
            });

            if (result.Success)
                Api.Connection.SetSid(null);

            return result;
        }
    }
}