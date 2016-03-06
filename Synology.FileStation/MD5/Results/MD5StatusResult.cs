using Newtonsoft.Json;

namespace Synology.FileStation.MD5.Results
{
	public class MD5StatusResult
	{
		public bool Finished { get; set; }
		public string MD5 { get; set; }
	}
}

