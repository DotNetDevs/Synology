using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synology.FileStation.CopyMove.Results
{
    public class StartResult
    {
        [JsonProperty("taskid")]
        public string TaskId { get; set; }
    }
}
