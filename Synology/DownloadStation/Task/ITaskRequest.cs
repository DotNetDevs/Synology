using System.Collections.Generic;
using Synology.Classes;
using Synology.DownloadStation.Task.Parameters;
using Synology.DownloadStation.Task.Results;
using Synology.Interfaces;

namespace Synology.DownloadStation.Task
{
    public interface ITaskRequest : ISynologyRequest
    {
        ResultData<TaskListResult> List(TaskListParameters parameters);

        ResultData<IEnumerable<TaskResult>> Info(TaskInfoParameters parameters);

        ResultData Create(TaskCreateParameters parameters);

        ResultData<IEnumerable<TaskMinimalResult>> Delete(TaskDeleteParameters parameters);

        ResultData<IEnumerable<TaskMinimalResult>> Pause(params string[] ids);

        ResultData<IEnumerable<TaskMinimalResult>> Resume(params string[] ids);

        ResultData<IEnumerable<TaskMinimalResult>> Edit(TaskEditParameters parameters);
    }
}
