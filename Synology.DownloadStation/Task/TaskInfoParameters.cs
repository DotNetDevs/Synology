using System;
using Synology.Classes;
using Synology.Utilities;

namespace Synology.DownloadStation.Task
{
	public class TaskInfoParameters : RequestParameters
	{
		public string[] Ids { get; set; }

		public TaskDetailsType? Additional { get; set; }

		public TaskInfoParameters()
		{
			Additional = null;
		}

		public override QueryStringParameter[] Parameters()
		{
			return new[] {
				new QueryStringParameter("id", Ids),
				new QueryStringParameter("additional", Additional)
			};
		}

	}
}

