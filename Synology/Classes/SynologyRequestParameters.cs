using Synology.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synology.Classes
{
	public class SynologyRequestParameters
	{
		public string Method { get; set; }
		public int Version { get; set; }
		public QueryStringParameter[] Additional { get; set; }

		public SynologyRequestParameters()
		{
			Version = 1;
		}
	}
}
