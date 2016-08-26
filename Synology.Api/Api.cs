using Synology.Classes;

namespace Synology.Api
{
    public class Api : SynologyApi
    {
        public Api(SynologyConnection connection) : base(connection)
        {
        }
    }
}