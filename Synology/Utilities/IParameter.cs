namespace Synology.Utilities
{
	/// <summary>
	/// 
	/// </summary>
	public interface IParameter
	{
		/// <summary>
		/// 
		/// </summary>
		string Name { get; }
		/// <summary>
		/// 
		/// </summary>
		string Value { get; }
		/// <summary>
		/// 
		/// </summary>
		int MinVersion { get; }
		/// <summary>
		/// 
		/// </summary>
		bool Empty { get; }
	}
}
