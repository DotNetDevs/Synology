using Synology.Classes;
using Synology.Utilities;
using Synology.Api.Auth.Parameters;
using Synology.Api.Auth.Results;
using Synology.Attributes;
using Synology.Parameters;

namespace Synology.Api.Auth
{
    public class AuthRequest : MainApiRequest
    {
        private string _sessionNumber;

        public AuthRequest(SynologyApi api) : base(api, "auth.cgi", "Auth")
        {
        }

        [RequestMethod("login")]
        public ResultData<AuthResult> Login(LoginParameters parameters)
        {
            _sessionNumber = parameters.SessionName;

            var result = GetData<AuthResult>(new SynologyRequestParameters
            {
                Version = 4,
                Additional = parameters
            });

            if (result.Success && !string.IsNullOrWhiteSpace(result.Data?.Sid))
                Api.Connection.Sid = result.Data.Sid;

            return result;
        }

        [RequestMethod("logout")]
        public ResultData Logout()
        {
            var parameters = new[] {
                new QueryStringParameter("session", _sessionNumber),
            };

            var result = GetData(new SynologyRequestParameters
            {
                Additional = parameters
            });

            if (result.Success)
                Api.Connection.Sid = null;

            return result;
        }
    }
}