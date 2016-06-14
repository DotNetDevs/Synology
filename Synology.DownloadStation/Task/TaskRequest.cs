using Synology.Classes;
using Synology.DownloadStation.Task.Parameters;
using Synology.DownloadStation.Task.Results;
using Synology.Utilities;
using System.Collections;
using System.Collections.Generic;
using Synology.Attributes;
using Synology.Parameters;

namespace Synology.DownloadStation.Task
{
    public class TaskRequest : DownloadStationRequest
    {
        public TaskRequest(SynologyApi api) : base(api, "task.cgi", "Task")
        {
        }

        [RequestMethod("list")]
        public ResultData<TaskListResult> List(TaskListParameters parameters)
        {
            return GetData<TaskListResult>(new SynologyRequestParameters
            {
                Additional = parameters
            });
        }

        [RequestMethod("getinfo")]
        public ResultData<IEnumerable<TaskResult>> Info(TaskInfoParameters parameters)
        {
            return GetData<IEnumerable<TaskResult>>(new SynologyRequestParameters
            {
                Additional = parameters
            });
        }

        [RequestMethod("create")]
        public ResultData Create(TaskCreateParameters parameters)
        {
            return GetData(new SynologyRequestParameters
            {
                Version = 3,
                Additional = parameters
            });
        }

        [RequestMethod("delete")]
        public ResultData<IEnumerable<TaskMinimalResult>> Delete(TaskDeleteParameters parameters)
        {
            return GetData<IEnumerable<TaskMinimalResult>>(new SynologyRequestParameters
            {
                Additional = parameters
            });
        }

        [RequestMethod("pause")]
        public ResultData<IEnumerable<TaskMinimalResult>> Pause(params string[] ids)
        {
            var additionalParams = new[] {
                new QueryStringParameter("id", ids)
            };

            return GetData<IEnumerable<TaskMinimalResult>>(new SynologyRequestParameters
            {
                Additional = additionalParams
            });
        }

        [RequestMethod("resume")]
        public ResultData<IEnumerable<TaskMinimalResult>> Resume(params string[] ids)
        {
            var additionalParams = new[] {
                new QueryStringParameter("id", ids),
            };

            return GetData<IEnumerable<TaskMinimalResult>>(new SynologyRequestParameters
            {
                Additional = additionalParams
            });
        }

        [RequestMethod("edit")]
        public ResultData<IEnumerable<TaskMinimalResult>> Edit(TaskEditParameters parameters)
        {
            return GetData<IEnumerable<TaskMinimalResult>>(new SynologyRequestParameters
            {
                Additional = parameters
            });
        }
    }
}

