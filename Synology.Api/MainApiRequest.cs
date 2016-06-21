using Synology.Attributes;
using Synology.Classes;

namespace Synology.Api
{
    [Request("API")]
    public abstract class MainApiRequest : SynologyRequest
    {
        protected MainApiRequest(SynologyApi parentApi) : base(parentApi)
        {
        }
    }
}