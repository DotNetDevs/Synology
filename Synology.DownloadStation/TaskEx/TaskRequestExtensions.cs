using Synology.DownloadStation;
using Synology.DownloadStation.TaskEx;
using Synology.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synology
{
    public static class TaskRequestExtensions
    {
        /// <summary>
        /// Download Station Task API (Extended)
        /// </summary>
        /// <param name="api"></param>
        /// <returns></returns>
        public static TaskRequest TaskEx(this DownloadStationApi api)
        {
            return RequestExtension<TaskRequest>.Request(api);
        }
    }
}
