using System;
using System.Collections;

namespace L04_HomeWork_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Какой объем сока необходимо упаковать?");
			string input = Console.ReadLine();
			float value = float.Parse(input);

			float bigContainer = 0;
			float middleContainer = 0;
			float smallContainer = 0;

			const int bigSize = 20;
			const int middleSize = 5;
			const int smallSize = 1;

			bigContainer = value / bigSize;
			if (bigContainer >= 1)
			{
				Console.WriteLine($"Количество контейнеров 20л: {Math.Floor(bigContainer)}");
			}
			value = value % bigSize;

			middleContainer = value / middleSize;
			if (middleContainer >= 1)
			{
				Console.WriteLine($"Количество контейнеров 5л: {Math.Floor(middleContainer)}");
			}
			value = value % middleSize;

			smallContainer = value / smallSize;
			if (smallContainer != 0)
			{
				Console.WriteLine($"Количество контейнеров 1л: {Math.Ceiling(smallContainer)}");
			}

		}
	}
}
