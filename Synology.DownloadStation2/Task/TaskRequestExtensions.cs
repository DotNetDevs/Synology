using Synology.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Synology.DownloadStation2;
using Synology.DownloadStation2.Task;

namespace Synology
{
    public static class TaskRequestExtensions
    {
        /// <summary>
        /// Download Station Task API (Extended)
        /// </summary>
        /// <param name="api"></param>
        /// <returns></returns>
        public static TaskRequest Task(this DownloadStation2Api api)
        {
            return RequestExtension<TaskRequest>.Request(api);
        }
    }
}
