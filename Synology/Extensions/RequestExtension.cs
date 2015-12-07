using System;
using Synology.Classes;

namespace Synology.Extensions
{
	public static class RequestExtension<T> where T : ApiRequest
	{
		private static T _request;

		public static T Request(SynologyApi api)
		{
			return _request ?? (_request = api.Request<T>());
		}
	}
}

