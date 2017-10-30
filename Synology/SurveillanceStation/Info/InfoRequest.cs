﻿using Synology.Attributes;
using Synology.Classes;
using Synology.SurveillanceStation.Info.Results;
using Synology.Parameters;

namespace Synology.SurveillanceStation.Info
{
	[Request("Info")]
    class InfoRequest : SurveillanceStationRequest, IInfoRequest
	{
        public InfoRequest(ISurveillanceStationApi api) : base(api)
		{
		}

		[RequestMethod("getinfo")]
		public ResultData<InfoResult> GetInfo()
		{
			return GetData<InfoResult>(new SynologyRequestParameters(this));
		}
	}
}
