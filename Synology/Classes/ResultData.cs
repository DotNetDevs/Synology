namespace Synology.Classes
{
	public class ResultData<T>
	{
		public T Data { get; set; }

		public bool Success { get; set; }

		public ResultError Error { get; set; }
	}
}