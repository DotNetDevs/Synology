namespace Synology.Utilities
{
    public interface IParameter
    {
        string Name { get; }
        string Value { get; }
        int MinVersion { get; }
        bool Empty { get; }
    }
}
