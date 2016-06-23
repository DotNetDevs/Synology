namespace Synology.Classes
{
	public class ResultData
	{
		public bool Success { get; set; }

		public ResultError Error { get; set; }
	}

	public class ResultData<T> : ResultData
	{
		public T Data { get; set; }
	}
}