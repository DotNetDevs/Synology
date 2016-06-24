using Synology.FileStation;
using Synology.FileStation.MD5;
using Synology.Extensions;

namespace Synology
{
	public static class FileStationMD5Extension
	{
		public static MD5Request MD5(this FileStationApi api)
		{
			return RequestExtension<MD5Request>.Request(api);
		}
	}
}