namespace Synology.Classes
{
	public abstract class SynologyApi
	{
		private readonly SynologyConnection _connection;

		protected SynologyApi(SynologyConnection connection)
		{
			_connection = connection;
		}

		public T Request<T>() where T : SynologyRequest
		{
			return _connection.Request<T>();
		}
	}
}