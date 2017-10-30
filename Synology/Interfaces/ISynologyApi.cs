using System;
namespace Synology.Interfaces
{
    public interface ISynologyApi
    {
        ISynologyConnection Connection { get; }
    }
}
