namespace L13_HomeWork_1
{
	public enum LogErrorType
	{
		Info,
		Warning,
		Error
	}
	class Program
	{
		static void Main(string[] args)
		{
			var writer1 = new FileLogWriter();
			writer1.LogError("001");
			writer1.LogInfo("Message 001");
			writer1.LogWarning("!!!");

			var writer2 = new ConsoleLogWriter();
			writer2.LogError("002");
			writer2.LogInfo("Message 002");
			writer2.LogWarning("!!!");

			var writers = new ILogWriter[2];
			writers[0] = writer1;
			writers[1] = writer2;

			var writer = new MultipleLogWriter(writers);

		}
	}
}
