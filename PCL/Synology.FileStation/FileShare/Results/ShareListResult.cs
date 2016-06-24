﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Synology.FileStation.FileShare.Results
{
	public class ShareListResult
	{
		public int Total { get; set; }

		public int Offset { get; set; }

		public IEnumerable<ShareResult> Shares { get; set; }
	}
}

