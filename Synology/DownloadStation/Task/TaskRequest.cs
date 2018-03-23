using Synology.Classes;
using Synology.DownloadStation.Task.Parameters;
using Synology.DownloadStation.Task.Results;
using Synology.Utilities;
using System.Collections.Generic;
using Synology.Attributes;
using Synology.Parameters;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace Synology.DownloadStation.Task
{
    [Request("Task")]
    internal class TaskRequest : DownloadStationRequest, ITaskRequest
    {
        public TaskRequest(IDownloadStationApi api) : base(api)
        {
        }

        [RequestMethod("list")]
        public async Task<ResultData<ITaskListResult>> ListAsync(TaskListParameters parameters)
        {
            return ResultData<ITaskListResult>.From(await this.GetDataAsync<TaskListResult>(new SynologyRequestParameters(this)
            {
                Additional = parameters
            }));
        }

        [RequestMethod("getinfo")]
        public async Task<ResultData<IEnumerable<ITaskResult>>> InfoAsync(TaskInfoParameters parameters)
        {
            var res = await this.GetDataAsync<IEnumerable<TaskResult>>(new SynologyRequestParameters(this)
            {
                Additional = parameters
            });

            return new ResultData<IEnumerable<ITaskResult>>
            {
                Data = res.Data.Cast<ITaskResult>(),
                Error = res.Error,
                Success = res.Success
            };
        }

        [RequestMethod("create")]
        public async Task<ResultData> CreateAsync(TaskCreateParameters parameters)
        {
            return await this.GetDataAsync(new SynologyRequestParameters(this)
            {
                Version = 3,
                Additional = parameters
            });
        }

        [RequestMethod("delete")]
        public async Task<ResultData<IEnumerable<ITaskMinimalResult>>> DeleteAsync(TaskDeleteParameters parameters)
        {
            var res = await this.GetDataAsync<IEnumerable<TaskMinimalResult>>(new SynologyRequestParameters(this)
            {
                Additional = parameters
            });

            return new ResultData<IEnumerable<ITaskMinimalResult>>
            {
                Data = res.Data.Cast<ITaskMinimalResult>(),
                Error = res.Error,
                Success = res.Success
            };
        }

        [RequestMethod("pause")]
        public async Task<ResultData<IEnumerable<ITaskMinimalResult>>> PauseAsync(params string[] ids)
        {
            var additionalParams = new[] {
                new QueryStringParameter("id", ids)
            };

            var res = await this.GetDataAsync<IEnumerable<TaskMinimalResult>>(new SynologyRequestParameters(this)
            {
                Additional = additionalParams
            });

            return new ResultData<IEnumerable<ITaskMinimalResult>>
            {
                Data = res.Data.Cast<ITaskMinimalResult>(),
                Error = res.Error,
                Success = res.Success
            };
        }

        [RequestMethod("resume")]
        public async Task<ResultData<IEnumerable<ITaskMinimalResult>>> ResumeAsync(params string[] ids)
        {
            var additionalParams = new[] {
                new QueryStringParameter("id", ids),
            };

            var res = await this.GetDataAsync<IEnumerable<TaskMinimalResult>>(new SynologyRequestParameters(this)
            {
                Additional = additionalParams
            });

            return new ResultData<IEnumerable<ITaskMinimalResult>>
            {
                Data = res.Data.Cast<ITaskMinimalResult>(),
                Error = res.Error,
                Success = res.Success
            };
        }

        [RequestMethod("edit")]
        public async Task<ResultData<IEnumerable<ITaskMinimalResult>>> EditAsync(TaskEditParameters parameters)
        {
            var res = await this.GetDataAsync<IEnumerable<TaskMinimalResult>>(new SynologyRequestParameters(this)
            {
                Additional = parameters
            });

            return new ResultData<IEnumerable<ITaskMinimalResult>>
            {
                Data = res.Data.Cast<ITaskMinimalResult>(),
                Error = res.Error,
                Success = res.Success
            };
        }
    }
}

