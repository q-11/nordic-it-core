using System;
using System.Collections.Generic;
using System.Text;

namespace L15_HomeWork_1
{
	public class LogWriterFactory
	{
		private static LogWriterFactory instance;
		private LogWriterFactory() { }
		public static LogWriterFactory getInstance()
		{
			if (instance == null)
				instance = new LogWriterFactory();

			return instance;
		}

		public ILogWriter GetLogWriter<T>(object parameters) where T : ILogWriter
		{
			if (typeof(T) == typeof(ConsoleLogWriter))
			{
				return new ConsoleLogWriter();
			}
			else if (typeof(T) == typeof(FileLogWriter))
			{
				return new FileLogWriter();
			}
			else if (typeof(T) == typeof(MultipleLogWriter))
			{
				return new MultipleLogWriter(parameters as ILogWriter[]);
			}

			return null;
		}
	}
}
