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
        [Obsolete("It uses Result, migrate to Async methods")]
		public ResultData<TaskListResult> List(TaskListParameters parameters)
		{
			return this.GetData<TaskListResult>(new SynologyRequestParameters(this)
			{
				Additional = parameters
			});
		}

		[RequestMethod("getinfo")]
        [Obsolete("It uses Result, migrate to Async methods")]
		public ResultData<IEnumerable<TaskResult>> Info(TaskInfoParameters parameters)
		{
            return this.GetData<IEnumerable<TaskResult>>(new SynologyRequestParameters(this)
			{
				Additional = parameters
			});
		}

		[RequestMethod("create")]
        [Obsolete("It uses Result, migrate to Async methods")]
		public ResultData Create(TaskCreateParameters parameters)
		{
            return this.GetData(new SynologyRequestParameters(this)
			{
				Version = 3,
				Additional = parameters
			});
		}

		[RequestMethod("delete")]
        [Obsolete("It uses Result, migrate to Async methods")]
		public ResultData<IEnumerable<TaskMinimalResult>> Delete(TaskDeleteParameters parameters)
		{
            return this.GetData<IEnumerable<TaskMinimalResult>>(new SynologyRequestParameters(this)
			{
				Additional = parameters
			});
		}

		[RequestMethod("pause")]
        [Obsolete("It uses Result, migrate to Async methods")]
		public ResultData<IEnumerable<TaskMinimalResult>> Pause(params string[] ids)
		{
			var additionalParams = new[] {
				new QueryStringParameter("id", ids)
			};

            return this.GetData<IEnumerable<TaskMinimalResult>>(new SynologyRequestParameters(this)
			{
				Additional = additionalParams
			});
		}

		[RequestMethod("resume")]
        [Obsolete("It uses Result, migrate to Async methods")]
		public ResultData<IEnumerable<TaskMinimalResult>> Resume(params string[] ids)
		{
			var additionalParams = new[] {
				new QueryStringParameter("id", ids),
			};

            return this.GetData<IEnumerable<TaskMinimalResult>>(new SynologyRequestParameters(this)
			{
				Additional = additionalParams
			});
		}

		[RequestMethod("edit")]
        [Obsolete("It uses Result, migrate to Async methods")]
		public ResultData<IEnumerable<TaskMinimalResult>> Edit(TaskEditParameters parameters)
		{
            return this.GetData<IEnumerable<TaskMinimalResult>>(new SynologyRequestParameters(this)
			{
				Additional = parameters
			});
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

