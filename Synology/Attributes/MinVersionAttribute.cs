using System;

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
