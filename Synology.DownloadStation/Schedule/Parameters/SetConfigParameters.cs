using System;
using Synology.Classes;
using Synology.Utilities;
using Synology.Parameters;

namespace Synology.DownloadStation.Schedule.Parameters
{
	public class SetConfigParameters : RequestParameters
	{
		public bool? Enabled { get; set; }

		public bool? EmuleEnabled { get; set; }

		public override QueryStringParameter[] Parameters()
		{
			return new[] {
				new QueryStringParameter("enabled", Enabled),
				new QueryStringParameter("emule_enabled", EmuleEnabled)
			};
		}
	}
}

