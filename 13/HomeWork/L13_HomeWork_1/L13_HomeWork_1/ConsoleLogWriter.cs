using System;

namespace L13_HomeWork_1
{
	public class ConsoleLogWriter : AbstractLogWriter
	{
		protected override void WriteSingleLine(string singleLine)
		{
			Console.WriteLine(singleLine);
		}
	}
}
