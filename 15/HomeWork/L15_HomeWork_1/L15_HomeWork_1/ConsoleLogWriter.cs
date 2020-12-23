using System;

namespace L15_HomeWork_1
{
	public class ConsoleLogWriter : AbstractLogWriter
	{
		protected override void WriteSingleLine(string singleLine)
		{
			Console.WriteLine(singleLine);
		}
	}
}