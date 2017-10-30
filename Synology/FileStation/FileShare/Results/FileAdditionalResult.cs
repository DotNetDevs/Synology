using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using Synology.FileStation.Common.Results;

namespace Synology.FileStation.FileShare.Results
{
    public class FileAdditionalResult : TaskFileAdditionalResult<FileOwnerResult, FileTimeResult, FilePermResult, FilePermAclResult>
    {
    }
}

