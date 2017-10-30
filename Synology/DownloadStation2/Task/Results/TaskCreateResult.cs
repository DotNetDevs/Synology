﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Synology.DownloadStation2.Task.Results
{
	/// <summary>
	/// 
	/// </summary>
	public class TaskCreateResult
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("list_id")]
		public IEnumerable<string> ListIds { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("task_id")]
		public IEnumerable<string> TaskIds { get; set; }
	}
}
