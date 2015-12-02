using Synology.FileStation;
using Synology.FileStation.Search;

namespace Synology
{
	public static class FileStationSearchExtension
	{
		private static SearchRequest _search;

		public static SearchRequest Search(this FileStationApi api)
		{
			if (_search == null)
			{
				api.RegisterRequest<SearchRequest>();
				_search = api.GetRequest<SearchRequest>();
			}

			return _search;
		}
	}
}

