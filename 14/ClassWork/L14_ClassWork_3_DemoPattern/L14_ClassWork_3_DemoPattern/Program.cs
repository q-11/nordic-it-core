using System;

namespace L14_ClassWork_3_DemoPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			var singlton1 = ConsoleWriter.GetInstance();
			var singlton2 = ConsoleWriter.GetInstance();
		}
	}
}
