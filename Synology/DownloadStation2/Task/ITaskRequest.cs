using Synology.Classes;
using Synology.DownloadStation2.Task.Parameters;
using Synology.DownloadStation2.Task.Results;
using Synology.Interfaces;

namespace Synology.DownloadStation2.Task
{
    public interface ITaskRequest : ISynologyRequest
    {
        ResultData<TaskCreateResult> Create(TaskCreateParameters parameters);
    }
}
