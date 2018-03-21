using System;
using System.Threading.Tasks;

namespace Synology.Interfaces
{
	/// <summary>
	/// 
	/// </summary>
	public interface ISynologyRequest
	{
		/// <summary>
		/// 
		/// </summary>
		ISynologyApi Api { get; }
        /// <summary>
        /// 
        /// </summary>
        [Obsolete("It uses Result, migrate to Async methods")]
        string CgiPath { get; }
        /// <summary>
        /// 
        /// </summary>
        Task<string> CgiPathAsync();
		/// <summary>
		/// 
		/// </summary>
		string ApiName { get; }
	}
}
