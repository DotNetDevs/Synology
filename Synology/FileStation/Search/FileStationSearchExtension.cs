﻿using Synology.FileStation;
using Synology.FileStation.Search;
using Synology.Extensions;

namespace Synology
{
	public static class FileStationSearchExtension
	{
		public static ISearchRequest Search(this IFileStationApi api)
		{
			return api.Request<ISearchRequest>();
		}
	}
}