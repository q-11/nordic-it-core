using System;

namespace L09_ClassWork_1
{
	class Program
	{
		static void Main(string[] args)
		{
			string input1 = Console.ReadLine();
			string input2 = Console.ReadLine();
			int sameLettrsNumber = 0;

			for (int i = 0; i < input1.Length; i++)
			{
				for (int j = 0; j < input2.Length; j++)
				{
					if(input1[i] == input2[j])
					{
						sameLettrsNumber++;
					}
				}
			}
			Console.WriteLine(sameLettrsNumber);
		}
	}
}
