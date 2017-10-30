using Synology.Interfaces;

namespace Synology.Classes
{
	/// <inheritdoc />
	/// <summary>
	/// </summary>
	public abstract class SynologyApi : ISynologyApi
	{
		/// <inheritdoc />
		/// <summary>
		/// </summary>
		public ISynologyConnection Connection { get; }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="connection"></param>
		protected SynologyApi(ISynologyConnection connection)
		{
			Connection = connection;
		}
	}
}