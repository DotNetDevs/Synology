using Synology.FileStation;
using Synology.FileStation.Search;

namespace Synology
{
	public static class FileStationSearchExtension
	{
		private static SearchRequest _search;

		public static SearchRequest Search(this FileStationApi api)
		{
			return _search ?? (_search = api.GetRequest<SearchRequest>());
		}
	}
}

