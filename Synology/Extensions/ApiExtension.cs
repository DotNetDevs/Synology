using System;
using Synology.Classes;

namespace Synology.Extensions
{
	public static class ApiExtension<T> where T : SynologyApi
	{
		private static T _api;

		public static T Api(SynologyConnection connection)
		{
			return _api ?? (_api = connection.Api<T>());
		}
	}
}

