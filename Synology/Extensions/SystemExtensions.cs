using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synology.Extensions
{
    public static class SystemExtensions
    {
        /// <summary>
        /// Performs conversion form a DateTime to Unix timestamp
        /// </summary>
        /// <param name="dateTime">The DateTime to convert</param>
        /// <returns>Unix timestamp</returns>
        public static long ToUnixTimeStamp(this DateTime dateTime)
        {
            return (long)dateTime.ToUniversalTime().Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
        }
    }
}
