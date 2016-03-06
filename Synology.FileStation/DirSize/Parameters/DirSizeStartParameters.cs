using Synology.Classes;
using Synology.Utilities;
using System.ComponentModel.DataAnnotations;
namespace Synology.FileStation.DirSize.Parameters
{
	public class DirSizeStartParameters : RequestParameters
	{
		[Required]
		public string Path { get; set; }

		public override QueryStringParameter[] Parameters()
		{
			return new[] {
				new QueryStringParameter("path", Path)
			};
		}
	}
}

