using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using Synology.FileStation.Common.Results;

namespace Synology.FileStation.List.Results
{
    public class FileListResult : TaskFileListResult<FileResult, FileListResult, FileAdditionalResult, FileOwnerResult, FileTimeResult, FilePermResult, FilePermAclResult>
	{
	}
}

