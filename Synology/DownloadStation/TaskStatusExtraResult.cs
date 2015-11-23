﻿using Newtonsoft.Json;

namespace Synology.DownloadStation
{
	public class TaskStatusExtraResult
	{
		[JsonProperty("error_detail")]
		public string ErrorDetail { get; set; }
		[JsonProperty("unzip_progress")]
		public int UnzipProgress { get; set; }
	}
}