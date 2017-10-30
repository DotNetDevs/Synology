using Synology.Classes;
using Synology.Interfaces;
using Synology.FileStation.CheckPermission.Parameters;

namespace Synology.FileStation.CheckPermission
{
    public interface ICheckPermissionRequest : ISynologyRequest
	{
        ResultData Write(CheckPermissionWriteParameters parameters);
	}
}