using Synology.Attributes;
using Synology.Classes;
using Synology.Interfaces;

namespace Synology.Api
{
    [Request("API")]
    internal abstract class MainApiRequest : SynologyRequest
    {
        protected MainApiRequest(IApi parentApi) : base(parentApi)
        {
        }
    }
}