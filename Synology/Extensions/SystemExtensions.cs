using System;

namespace Synology.Extensions
{
    public static class SystemExtensions
    {
        /// <summary>
        /// Performs conversion form a DateTime to Unix timestamp
        /// </summary>
        /// <param name="dateTime">The DateTime to convert</param>
        /// <returns>Unix timestamp</returns>
        public static long ToUnixTimeStamp(this DateTime dateTime) => (long)dateTime.ToUniversalTime().Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
    }
}
