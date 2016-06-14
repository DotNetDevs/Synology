using Synology.Classes;
using Synology.Parameters;
using Synology.Utilities;
using System.ComponentModel.DataAnnotations;
namespace Synology.FileStation.DirSize.Parameters
{
	public class DirSizeStatusParameters : RequestParameters
	{
		[Required]
		public string TaskID { get; set; }

		public override QueryStringParameter[] Parameters()
		{
			return new[] {
				new QueryStringParameter("taskid", TaskID)
			};
		}
	}
}

