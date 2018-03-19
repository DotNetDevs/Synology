using System;

namespace Synology.Attributes
{
/// <inheritdoc />
/// <summary>
/// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class RequestMethodAttribute : Attribute
    {
	/// <summary>
	/// 
	/// </summary>
        public string Name { get; }

		/// <inheritdoc />
		/// <summary>
		/// </summary>
		/// <param name="name"></param>
        public RequestMethodAttribute(string name)
        {
            Name = name;
        }
    }
}
