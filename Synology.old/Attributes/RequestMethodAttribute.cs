using System;

namespace Synology.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class RequestMethodAttribute : Attribute
    {
        public string Name { get; }

        public RequestMethodAttribute(string name)
        {
            Name = name;
        }
    }
}
