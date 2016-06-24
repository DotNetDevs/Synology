﻿using System;
using Synology.Classes;
using Synology.Utilities;
using System.ComponentModel;
using Synology.Attributes;
using Synology.FileStation.Thumb.Parameters;
using Synology.Parameters;

namespace Synology.FileStation.Thumb
{
	[Request("Thumb")]
	public class ThumbRequest : FileStationRequest
	{
		public ThumbRequest(SynologyApi api) : base(api)
		{
		}

		[RequestMethod("get")]
		public ResultData<byte[]> Get(ThumbGetParameters parameters)
		{
			return GetData<byte[]>(new SynologyRequestParameters(this)
			{
				Additional = parameters
			});
		}
	}
}