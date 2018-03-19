using Synology.Classes;
using Synology.Interfaces;

namespace Synology.Api
{
	internal class Api : SynologyApi, IApi
    {
        public Api(ISynologyConnection connection) : base(connection)
        {
        }
    }
}