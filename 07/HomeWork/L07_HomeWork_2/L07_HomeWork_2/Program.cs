using System;
using System.Net.Http.Headers;

namespace L07_HomeWork_2
{
	class Program
	{
		static void Main(string[] args)
		{
			string line = Console.ReadLine();
			char[] lettersOfLine = line.ToLower().ToCharArray();

			for (int i = lettersOfLine.Length - 1; i >= 0; i--)
			{
				Console.Write(lettersOfLine[i]);
			}

		}
	}
}
