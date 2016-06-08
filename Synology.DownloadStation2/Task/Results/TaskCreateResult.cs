using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synology.DownloadStation2.Task.Results
{
    public class TaskCreateResult
    {
        [JsonProperty("list_id")]
        public IEnumerable<string> ListIds { get; set; }

        [JsonProperty("task_id")]
        public IEnumerable<string> TaskIds { get; set; }
    }
}
