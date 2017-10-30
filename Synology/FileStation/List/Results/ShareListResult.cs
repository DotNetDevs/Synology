using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Synology.FileStation.Common.Results;

namespace Synology.FileStation.List.Results
{
    public class ShareListResult : TaskShareListResult<ShareAdditionalResult, ShareResult, ShareOwnerResult, ShareTimeResult, SharePermResult, SharePermAclResult, ShareVolumeStatusResult, SharePermAdvRightResult>
    {
    }
}
