using System;

namespace Synology.Extensions
{
    public static class SystemExtensions
    {
        /// <summary>
        /// Performs conversion from a DateTime to Unix timestamp
        /// </summary>
        /// <param name="dateTime">The DateTime to convert</param>
        /// <returns>Unix timestamp</returns>
        public static long ToUnixTimeStamp(this DateTime dateTime) => (long)dateTime.ToUniversalTime().Subtract(new DateTime(1970, 1, 1)).TotalSeconds;

        /// <summary>
        /// Performs conversion from a Unix timestamp to a DateTime
        /// </summary>
        /// <param name="dateTime">The timstamp to convert</param>
        /// <returns>DateTime</returns>
        public static DateTime ToDateTime(this long timestamp) => new DateTime(1970,1,1,0,0,0,0, System.DateTimeKind.Utc).AddSeconds(timestamp).ToLocalTime();
    }
}
