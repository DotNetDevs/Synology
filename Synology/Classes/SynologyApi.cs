using Synology.Parameters;
using System.Threading.Tasks;
using Synology.Interfaces;
using Synology.Extensions;

namespace Synology.Classes
{
    public abstract class SynologyApi : ISynologyApi
    {
        public ISynologyConnection Connection { get; }

        protected SynologyApi(ISynologyConnection connection)
        {
            Connection = connection;
        }
    }
}