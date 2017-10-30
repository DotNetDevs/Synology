﻿using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Synology.Attributes;
using System.Collections.Generic;
using Synology.Parameters;
using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Synology.Api.Info;
using Synology.Interfaces;
using Synology.Extensions;

namespace Synology.Classes
{
    [Request("SYNO")]
    internal abstract class SynologyRequest : ISynologyRequest
    {
        public ISynologyApi Api { get; }
        public string CgiPath { get; }

        public static string GetApiName<T>() => GetApiName(typeof(T));

        public static string GetApiName(Type t)
        {
            var ty = t.GetTypeInfo();
            var res = new List<string>();

            while (ty != null)
            {
                if (ty.GetCustomAttribute(typeof(RequestAttribute)) is RequestAttribute ta)
                    res.Insert(0, ta.Name);

                ty = ty.BaseType?.GetTypeInfo();
            }

            return string.Join(".", res);
        }

        public string ApiName => GetApiName(GetType());

        protected SynologyRequest(ISynologyApi api)
        {
            Api = api;

            //Fixed possible loop for LoadInfo
            if (ApiName == "SYNO.API.Info")
            {
                CgiPath = "query.cgi";
            }
            else
            {
                //Request and Method returns null if the API or the Method is not found.
                var request = api.Connection.ServiceProvider.GetService<IInfoRequest>() as ISynologyRequest;
                var data = request?.Method<Dictionary<string, IApiInfo>>("query", new object[] { new[] { ApiName } });

                //Request and Method returns null if the API or the Method is not found.
                //If the Info API has returned a value and contains the current API Info, this update the associated cgi.
                if (data != null && data.Data.ContainsKey(ApiName))
                {
                    CgiPath = data.Data[ApiName].Path;
                }
                else
                {
                    throw new Exception("The API cannot be found on this Synology. Check if RequestAttribute exists on the relative SynologyRequest subclass or the SYNO.API.Info result.");
                }
            }

            Api.Connection.Logger.LogDebug($"Created request {ApiName} to path {CgiPath}");
        }

        protected ResultData<T> GetData<T>(SynologyRequestParameters parameters) => Api.GetData<T>(CgiPath, ApiName, parameters);

        protected ResultData GetData(SynologyRequestParameters parameters) => Api.GetData(CgiPath, ApiName, parameters);

        protected async Task<ResultData<T>> GetDataAsync<T>(SynologyRequestParameters parameters) => await Api.GetDataAsync<T>(CgiPath, ApiName, parameters);

        protected async Task<ResultData> GetDataAsync(SynologyRequestParameters parameters) => await Api.GetDataAsync(CgiPath, ApiName, parameters);

        /// <summary>
        /// Performs synchronous post request with specific response
        /// </summary>
        /// <typeparam name="T">Type of the result data</typeparam>
        /// <param name="parameters">Parameters used for the request</param>
        /// <returns>Specific result data</returns>
        protected ResultData<T> PostData<T>(SynologyPostParameters parameters) => Api.PostData<T>(CgiPath, ApiName, parameters);

        /// <summary>
        /// Performs synchronous post request
        /// </summary>
        /// <param name="parameters">Parameters used for the request</param>
        /// <returns>Generic result data</returns>
        protected ResultData PostData(SynologyPostParameters parameters) => Api.PostData(CgiPath, ApiName, parameters);

        /// <summary>
        /// Performs asynchronous post request with specific response
        /// </summary>
        /// <typeparam name="T">Type of the result data</typeparam>
        /// <param name="parameters">Parameters used for the request</param>
        /// <returns>Specific result data</returns>
        protected async Task<ResultData<T>> PostDataAsync<T>(SynologyPostParameters parameters) => await Api.PostDataAsync<T>(CgiPath, ApiName, parameters);

        /// <summary>
        /// Performs asynchronous post request
        /// </summary>
        /// <param name="parameters">Parameters used for the request</param>
        /// <returns>Generic result data</returns>
        protected async Task<ResultData> PostDataAsync(SynologyPostParameters parameters) => await Api.PostDataAsync(CgiPath, ApiName, parameters);
    }
}
