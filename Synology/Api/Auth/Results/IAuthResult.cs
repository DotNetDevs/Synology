namespace Synology.Api.Auth.Results
{
    /// <summary>
    /// Auth result.
    /// </summary>
    public interface IAuthResult
    {
        /// <summary>
        /// Gets the sid.
        /// </summary>
        /// <value>The sid.</value>
        string Sid { get; }
    }
}