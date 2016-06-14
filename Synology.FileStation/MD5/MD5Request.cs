using Synology.Attributes;
using Synology.Classes;
using Synology.FileStation.MD5.Parameters;
using Synology.FileStation.MD5.Results;
using Synology.Parameters;

namespace Synology.FileStation.MD5
{
    public class MD5Request : FileStationRequest
    {
        public MD5Request(SynologyApi api) : base(api, "MD5")
        {
        }

        [RequestMethod("start")]
        public ResultData<MD5StartResult> Start(MD5StartParameters parameters)
        {
            return GetData<MD5StartResult>(new SynologyRequestParameters
            {
                Additional = parameters
            });
        }

        [RequestMethod("status")]
        public ResultData<MD5StatusResult> Status(MD5StatusParameters parameters)
        {
            return GetData<MD5StatusResult>(new SynologyRequestParameters
            {
                Additional = parameters
            });
        }

        [RequestMethod("stop")]
        public ResultData Stop(MD5StatusParameters parameters)
        {
            return GetData(new SynologyRequestParameters
            {
                Additional = parameters
            });
        }
    }
}