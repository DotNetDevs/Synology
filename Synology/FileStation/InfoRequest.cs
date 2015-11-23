using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Synology.Classes;

namespace Synology.FileStation
{
	public class InfoRequest : SynologyRequest
	{
		internal InfoRequest(SynologyConnection connection) : base(connection, "FileStation/info.cgi", "SYNO.FileStation.Info")
		{
		}

		public ResultData<InfoResult> Info()
		{
			var url = GetApiUrl("getinfo");
			return Connection.GetDataFromUrl<InfoResult>(url);
		}
	}
}
