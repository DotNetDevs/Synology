using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Synology.Attributes;
using Synology.Classes;
using Synology.FileStation.Info.Results;
using Synology.Interfaces;
using Synology.Parameters;

namespace Synology.FileStation.Info
{
	[Request("Info")]
    internal class InfoRequest : FileStationRequest, IInfoRequest
	{
        public InfoRequest(IFileStationApi api) : base(api)
		{
		}

		[RequestMethod("get")]
		public ResultData<InfoResult> Get()
		{
			return GetData<InfoResult>(new SynologyRequestParameters(this));
		}
	}
}
