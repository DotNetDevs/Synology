using Newtonsoft.Json;

namespace Synology.Classes
{
    /// <summary>
    /// 
    /// </summary>
    public class ResultData
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("error")]
        public ResultError Error { get; set; }

        internal static ResultData<TDest> Convert<TSource, TDest>(ResultData<TSource> source) where TSource : class, TDest, new()
        {
            return new ResultData<TDest>
            {
                Data = source.Data,
                Error = source.Error,
                Success = source.Success
            };
        }
    }

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class ResultData<T> : ResultData
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data")]
        public T Data { get; set; }

        internal static ResultData<T> From<TSource>(ResultData<TSource> source) where TSource : class, T, new() => ResultData.Convert<TSource, T>(source);
    }
}