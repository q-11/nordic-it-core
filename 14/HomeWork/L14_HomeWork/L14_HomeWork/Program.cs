
using System;

namespace L14_HomeWork
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
			//create
			var fileLogWriter1 = FileLogWriter.GetInstance();
			var fileLogWriter2 = FileLogWriter.GetInstance();
			var consoleLogWriter1 = ConsoleLogWriter.GetInstance();
			var consoleLogWriter2 = ConsoleLogWriter.GetInstance();

			var writers1 = new ILogWriter[2];
			var writers2 = new ILogWriter[2];

			var multipleWriter1 = MultipleLogWriter.GetInstance(writers1);
			var multipleWriter2 = MultipleLogWriter.GetInstance(writers2);

			//initialization
			writers1[0] = consoleLogWriter1;
			writers1[1] = consoleLogWriter2;
			writers2[0] = fileLogWriter1;
			writers2[1] = fileLogWriter2;

			fileLogWriter1.LogError("FileLogWriter1\tERROR");
			fileLogWriter1.LogInfo("FileLogWriter1\tINFO");
			fileLogWriter1.LogWarning("FileLogWriter1\tWARNING");
			fileLogWriter2.LogError("FileLogWriter2\tERROR");
			fileLogWriter2.LogInfo("FileLogWriter2\tINFO");
			fileLogWriter2.LogWarning("FileLogWriter2\tWARNING");

			consoleLogWriter1.LogError("ConsoleLogWriter1\tERROR");
			consoleLogWriter1.LogInfo("ConsoleLogWriter1\tINFO");
			consoleLogWriter1.LogWarning("ConsoleLogWriter1\tWARNING");
			consoleLogWriter2.LogError("ConsoleLogWriter2\tERROR");
			consoleLogWriter2.LogInfo("ConsoleLogWriter2\tINFO");
			consoleLogWriter2.LogWarning("ConsoleLogWriter2\tWARNING");
			Console.WriteLine();

			//compare
			Console.WriteLine(fileLogWriter1 == fileLogWriter2);
			Console.WriteLine(consoleLogWriter1 == consoleLogWriter2);
			Console.WriteLine(multipleWriter2 == multipleWriter1);
		}
	}
}
