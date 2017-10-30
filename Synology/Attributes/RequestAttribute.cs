using System;

namespace Synology.Attributes
{
	/// <inheritdoc />
	/// <summary>
	/// </summary>
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, Inherited = false)]
    public sealed class RequestAttribute : Attribute
    {
	/// <summary>
	/// 
	/// </summary>
        public string Name { get; }

		/// <inheritdoc />
		/// <summary>
		/// </summary>
		/// <param name="name"></param>
        public RequestAttribute(string name)
        {
            Name = name;
        }
    }
}
