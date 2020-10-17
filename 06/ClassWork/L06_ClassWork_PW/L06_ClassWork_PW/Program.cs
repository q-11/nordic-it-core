using System;
using System.Net.Mail;

namespace L06_ClassWork_PW
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter something text or enter exit");
			string line;
			int strLength = 0;
			do
			{
				line = Console.ReadLine();
				strLength = line.Length;

				if (line == "exit") break;
				if (strLength > 15)
				{
					Console.WriteLine(strLength);
					Console.Write("You entered line which length > 15. Try again.. ");
					continue;
				}

				Console.WriteLine($"Entered string length is {strLength}");
			} while (true);
		}
	}
}
