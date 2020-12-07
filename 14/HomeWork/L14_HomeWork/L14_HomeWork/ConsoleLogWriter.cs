using System;
using System.Collections.Generic;
using System.Text;

namespace L14_HomeWork
{
	public class ConsoleLogWriter : AbstractLogWriter
	{
		private static ConsoleLogWriter _instance;
		private ConsoleLogWriter() { }
		public static ConsoleLogWriter GetInstance()
		{
			if (_instance == null)
				_instance = new ConsoleLogWriter();
			return _instance;
		}
		protected override void WriteSingleLine(string singleLine)
		{
			Console.WriteLine(singleLine);
		}
	}
}
