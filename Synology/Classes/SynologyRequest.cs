﻿using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Synology.Attributes;
using System.Collections.Generic;
using Synology.Parameters;

namespace Synology.Classes
{
    [Request("SYNO")]
    public abstract class SynologyRequest
    {
        public readonly SynologyApi Api;
        public string CgiPath { get; private set; }
        public string ApiName { get; private set; }

        protected SynologyRequest(SynologyApi api, string cgiPath, string apiName)
        {
            Api = api;
            CgiPath = cgiPath;
            ApiName = $"SYNO.{apiName}";

            Api.Connection.Logger.Debug($"Created request {ApiName} to path {cgiPath}");

            LoadInfo();

            Api.Connection.Logger.Debug($"Updated request {ApiName} to path {cgiPath} with LoadInfo");
        }

        private string AttributesApiName
        {
            get
            {
                var ty = GetType();
                var res = new List<string>();

                while (ty != null)
                {
                    var ta = ty.GetCustomAttribute(typeof(RequestAttribute)) as RequestAttribute;

                    if (ta != null)
                        res.Insert(0, ta.Name);

                    ty = ty.BaseType;
                }

                if (res.Count > 2)
                {
                    return string.Join(".", res);
                }

                return ApiName;
            }
        }

        private void LoadInfo()
        {
            //Fixed possible loop for LoadInfo
            if (AttributesApiName == "SYNO.API.Info" || ApiName == "SYNO.API.Info") return;

            //Request and Method returns null if the API or the Method is not found.
            var data = Api.Connection.Request("SYNO.API.Info")?.Method<Dictionary<string, ApiInfo>>("query", AttributesApiName, ApiName);

            //If the Info API has returned a value and contains the current API Info, this update the associated cgi.
            if (data != null && data.Data.ContainsKey(AttributesApiName))
            {
                ApiName = AttributesApiName;
                CgiPath = data.Data[AttributesApiName].Path;
            }
            else
            {
                //Request and Method returns null if the API or the Method is not found.
                //If the Info API has returned a value and contains the current API Info, this update the associated cgi.
                if (data != null && data.Data.ContainsKey(ApiName))
                {
                    CgiPath = data.Data[ApiName].Path;
                }
            }
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

        private T MethodResult<T>(string name, params object[] parameters) where T : ResultData => GetType().GetMethods().Where(t => t.CustomAttributes.Any(a => a.AttributeType == typeof(RequestMethodAttribute))).FirstOrDefault(t => t.GetCustomAttributes(typeof(RequestMethodAttribute), true).Cast<RequestMethodAttribute>().FirstOrDefault()?.Name == name)?.Invoke(this, parameters) as T;

        internal ResultData Method(string name, params object[] parameters) => MethodResult<ResultData>(name, parameters);

        internal ResultData<T> Method<T>(string name, params object[] parameters) => MethodResult<ResultData<T>>(name, parameters);
    }
}