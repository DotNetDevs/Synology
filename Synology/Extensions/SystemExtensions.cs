using System;

namespace Synology
{
	/// <summary>
	/// 
	/// </summary>
	internal static class SystemExtensions
	{
		/// <summary>
		/// Performs conversion from a DateTime to Unix timestamp
		/// </summary>
		/// <param name="dateTime">The DateTime to convert</param>
		/// <returns>Unix timestamp</returns>
		internal static long ToUnixTimeStamp(this DateTime dateTime) => (long)dateTime.ToUniversalTime().Subtract(new DateTime(1970, 1, 1)).TotalSeconds;

		/// <summary>
		/// Performs conversion from a Unix timestamp to a DateTime
		/// </summary>
		/// <param name="timestamp">The timstamp to convert</param>
		/// <returns>DateTime</returns>
		internal static DateTime ToDateTime(this long timestamp) => new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(timestamp).ToLocalTime();
	}
}
