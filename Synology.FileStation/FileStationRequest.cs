using Synology.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synology.FileStation
{
	public abstract class FileStationRequest : ApiRequest
	{
		protected FileStationRequest(SynologyConnection connection, string cgiPath, string api) : base(connection, $"FileStation/{cgiPath}", $"FileStation.{api}")
		{
		}
	}
}
