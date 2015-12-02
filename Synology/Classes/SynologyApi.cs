namespace Synology.Classes
{
	public abstract class SynologyApi
	{
		private readonly SynologyConnection _connection;

		protected SynologyApi(SynologyConnection connection)
		{
			_connection = connection;
		}

		public void RegisterRequest<T>() where T : SynologyRequest
		{
			_connection.RegisterRequest<T>();
		}

		public T ResolveRequest<T>() where T : SynologyRequest
		{
			return _connection.GetRequest<T>();
		}
	}
}