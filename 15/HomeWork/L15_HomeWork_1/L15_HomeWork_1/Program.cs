using System;

namespace L15_HomeWork_1
{
	class Program
	{
		delegate ILogWriter LogWriter(string LogError, string LogInfo, string LogWarning);
		static void Main(string[] args)
		{

			var factory = LogWriterFactory.getInstance();
			var writers = new ILogWriter[2];

			var consoleWriter = factory.GetLogWriter<ConsoleLogWriter>(null);
			var logWriter = factory.GetLogWriter<FileLogWriter>("log.txt");

			writers[0] = consoleWriter;
			writers[1] = logWriter;

			writers[0].LogError("ConsoleLogWriter\tERROR");
			writers[0].LogInfo("ConsoleLogWriter\tINFO");
			writers[0].LogWarning("ConsoleLogWriter\tWARNING");

			writers[1].LogError("FileLogWriter\tERROR");
			writers[1].LogInfo("FileLogWriter\tINFO");
			writers[1].LogWarning("FileLogWriter\tWARNING");

			var factory1 = LogWriterFactory.getInstance();
			var writers1 = new ILogWriter[2];

			var consoleWriter1 = factory.GetLogWriter<ConsoleLogWriter>(null);
			var logWriter1 = factory.GetLogWriter<FileLogWriter>("log.txt");

			writers1[0] = consoleWriter1;
			writers1[1] = logWriter1;

			writers1[0].LogError("ConsoleLogWriter\tERROR");
			writers1[0].LogInfo("ConsoleLogWriter\tINFO");
			writers1[0].LogWarning("ConsoleLogWriter\tWARNING");

			writers1[1].LogError("FileLogWriter\tERROR");
			writers1[1].LogInfo("FileLogWriter\tINFO");
			writers1[1].LogWarning("FileLogWriter\tWARNING");

			factory1.GetLogWriter<MultipleLogWriter>(writers);

			Console.WriteLine(factory1 == factory);

		}
	}
}