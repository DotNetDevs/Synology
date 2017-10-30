using System;

namespace Synology.Attributes
{
	/// <inheritdoc />
	/// <summary>
	/// </summary>
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class MinVersionAttribute : Attribute
	{
		/// <summary>
		/// 
		/// </summary>
		public int MinVersion { get; }

		/// <inheritdoc />
		/// <summary>
		/// </summary>
		/// <param name="minVersion"></param>
		public MinVersionAttribute(int minVersion)
		{
			MinVersion = minVersion;
		}
	}
}
