using Synology.Interfaces;

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