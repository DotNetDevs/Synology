using Synology.Classes;
using Synology.DownloadStation.Task.Parameters;
using Synology.DownloadStation.Task.Results;
using Synology.Utilities;
using System.Collections.Generic;
using Synology.Attributes;
using Synology.Parameters;
using System.Threading.Tasks;
using System;

namespace Synology.DownloadStation.Task
{
	[Request("Task")]
	internal class TaskRequest : DownloadStationRequest, ITaskRequest
	{
		public TaskRequest(IDownloadStationApi api) : base(api)
		{
		}

        [RequestMethod("list")]
        public async Task<ResultData<TaskListResult>> ListAsync(TaskListParameters parameters)
        {
            return await this.GetDataAsync<TaskListResult>(new SynologyRequestParameters(this)
            {
                Additional = parameters
            });
        }

        [RequestMethod("getinfo")]
        public async Task<ResultData<IEnumerable<TaskResult>>> InfoAsync(TaskInfoParameters parameters)
        {
            return await this.GetDataAsync<IEnumerable<TaskResult>>(new SynologyRequestParameters(this)
            {
                Additional = parameters
            });
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
        public async Task<ResultData<IEnumerable<TaskMinimalResult>>> DeleteAsync(TaskDeleteParameters parameters)
        {
            return await this.GetDataAsync<IEnumerable<TaskMinimalResult>>(new SynologyRequestParameters(this)
            {
                Additional = parameters
            });
        }

        [RequestMethod("pause")]
        public async Task<ResultData<IEnumerable<TaskMinimalResult>>> PauseAsync(params string[] ids)
        {
            var additionalParams = new[] {
                new QueryStringParameter("id", ids)
            };

            return await this.GetDataAsync<IEnumerable<TaskMinimalResult>>(new SynologyRequestParameters(this)
            {
                Additional = additionalParams
            });
        }

        [RequestMethod("resume")]
        public async Task<ResultData<IEnumerable<TaskMinimalResult>>> ResumeAsync(params string[] ids)
        {
            var additionalParams = new[] {
                new QueryStringParameter("id", ids),
            };

            return await this.GetDataAsync<IEnumerable<TaskMinimalResult>>(new SynologyRequestParameters(this)
            {
                Additional = additionalParams
            });
        }

        [RequestMethod("edit")]
        public async Task<ResultData<IEnumerable<TaskMinimalResult>>> EditAsync(TaskEditParameters parameters)
        {
            return await this.GetDataAsync<IEnumerable<TaskMinimalResult>>(new SynologyRequestParameters(this)
            {
                Additional = parameters
            });
        }
	}
}

