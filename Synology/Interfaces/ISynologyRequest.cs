using System;
namespace Synology.Interfaces
{
    public interface ISynologyRequest
    {
        ISynologyApi Api { get; }
        string CgiPath { get; }
        string ApiName { get;  }
    }
}
