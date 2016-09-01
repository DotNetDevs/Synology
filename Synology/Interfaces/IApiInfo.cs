namespace Synology.Interfaces
{
    public interface IApiInfo
    {
        string Path { get; }
        int MinVersion { get; }
        int MaxVersion { get; }
    }
}
