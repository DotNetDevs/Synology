using Synology.FileStation;
using Synology.FileStation.Search;
using Synology.Extensions;

namespace Synology
{
	public static class FileStationSearchExtension
	{
		public static SearchRequest Search(this FileStationApi api)
		{
			return RequestExtension<SearchRequest>.Request(api);
		}
	}
}