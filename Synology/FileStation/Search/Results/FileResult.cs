using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using Synology.FileStation.Common.Results;

namespace Synology.FileStation.Search.Results
{
    public class FileResult : TaskFileResult<FileListResult, FileAdditionalResult, FileOwnerResult, FileTimeResult, FilePermResult, FilePermAclResult, FileResult>
	{
	}

}

