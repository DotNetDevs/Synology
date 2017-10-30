using System;
using Synology.Classes;
using Synology.Interfaces;
using Synology.Utilities;
using System.ComponentModel;
using Synology.Attributes;
using Synology.FileStation.CheckPermission.Parameters;
using Synology.Parameters;

namespace Synology.FileStation.CheckPermission
{
    public interface ICheckPermissionRequest : ISynologyRequest
	{
        ResultData Write(CheckPermissionWriteParameters parameters);
	}
}