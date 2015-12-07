using Synology.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Synology.Utilities;

namespace Synology.DownloadStation.Task.Parameters
{
	public class TaskCreateParameters : RequestParameters
	{
		public string Uri { get; set; }
		public string File { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string UnzipPassword { get; set; }
		public string Destination { get; set; }

		public override QueryStringParameter[] Parameters()
		{
			return new[] {
				new QueryStringParameter("uri", Uri),
				new QueryStringParameter("file", File),
				new QueryStringParameter("username", Username),
				new QueryStringParameter("password", Password),
				new QueryStringParameter("unzip_password", UnzipPassword),
				new QueryStringParameter("destination", Destination),
			};
		}
	}
}
