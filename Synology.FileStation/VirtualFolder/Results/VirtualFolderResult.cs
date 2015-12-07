using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Dynamic;
using System.Configuration;

namespace Synology.FileStation.VirtualFolder.Results
{
	public class VirtualFolderResult
	{
		public string Path { get; set; }

		public string Name { get; set; }

		public VirtualFolderAdditionalResult Additional { get; set; }
	}

}

