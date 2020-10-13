using System;
using System.Diagnostics;

namespace L03_HomeWork_2
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] sourceFactors1 = new int[10];
			int[] sourceFactors2 = new int[sourceFactors1.Length];
			for (int i = 0; i < sourceFactors1.Length; i++)
			{
				sourceFactors1[i] = i + 1;
				sourceFactors2[i] = i + 1;
			}
			for (int i1 = 0; i1 < sourceFactors1.Length; i1++) {
				for (int i2 = 0; i2 < sourceFactors1.Length; i2++)
				{
					int outPut;
					outPut = sourceFactors1[i2] * sourceFactors2[i1];
					if (outPut <= 9)
						Console.Write(outPut + "   ");
					else if (outPut <= 99)
						Console.Write(outPut + "  ");
					else if (outPut >= 100)
						Console.Write(outPut + " ");
				}
				Console.WriteLine();
			}
		}
	}
}
