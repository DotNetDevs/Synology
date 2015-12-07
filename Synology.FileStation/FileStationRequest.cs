using Synology.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synology.FileStation
{
	public abstract class FileStationRequest : SynologyRequest
	{
		protected FileStationRequest(SynologyApi parentApi, string cgiPath, string api) : base(parentApi, $"FileStation/{cgiPath}", $"FileStation.{api}")
		{
		}
	}
}
