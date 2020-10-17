using System;

namespace L06_ClassWork_PW2
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = { 1, -1, -2, 4 };
			int sum = 0;
			int sum2 = 0;
			//int currentNumberIndex = 0;

			for (int i = 0; i != numbers.Length; i++)
			{
				if (numbers[i] > 0)
				{
					sum += numbers[i];
					Console.WriteLine($"Текущая сумма положительных чисел = {sum}");
				}
				else
				{
					sum2 += numbers[i];
					Console.WriteLine($"Текущая сумма отрицательных чисел = {sum2}");
				}
			}

			//while (currentNumberIndex != numbers.Length)
			//{
			//	sum = sum + numbers[currentNumberIndex];
			//	Console.WriteLine(sum);
			//	currentNumberIndex++;
			//}
			Console.WriteLine($"Сумма положительных = {sum}");
			Console.WriteLine($"Сумма отрицательных = {sum2}");
		}
	}
}
