using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synology.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class MinVersionAttribute : Attribute
    {
        public int MinVersion { get; }

        public MinVersionAttribute(int minVersion)
        {
            MinVersion = minVersion;
        }
    }
}
