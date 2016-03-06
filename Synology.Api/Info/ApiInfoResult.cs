using System;
namespace Synology.Api.Info
{
	public class ApiInfoResult
	{
		public string Path { get; set; }
		public int MinVersion { get; set; }
		public int MaxVersion { get; set; }
	}
}

