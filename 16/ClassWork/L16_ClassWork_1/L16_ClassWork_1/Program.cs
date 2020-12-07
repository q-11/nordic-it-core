using System;

namespace L16_ClassWork_1
{
	delegate int GetNumberFromNumbers(int[] numbers);
	// int (int[])
	class Program
	{
		static void Main(string[] args)
		{
			var arrayForTeats = new[] { 2, 4, 1, 5 };

			GetNumberFromNumbers calculate;

			calculate = Sum;
			WriteNumberFromNumbers(calculate, arrayForTeats);

			calculate = Average;
			WriteNumberFromNumbers(calculate, arrayForTeats);

			//lamda demo
			WriteNumberFromNumbers((int[] arr) =>
			{
				int result = int.MinValue;
				foreach (int number in arr)
				{
					result = number > result
					? result
					: number;
				}

				return result;
			
			}, arrayForTeats);

			Func<int, bool> isNegativeOrZero = x => x <= 0;
			int i = int.Parse(Console.ReadLine());
			Console.WriteLine(isNegativeOrZero(i));
		}
		static void WriteNumberFromNumbers(GetNumberFromNumbers calculate, int[] array)
		{
			Console.WriteLine(calculate(array));
		}
		static int Sum(int[] array)
		{
			int result = 0;

			foreach (var number in array)
			{
				result += number;
			}

			return result;
		}
		static int Average(int[] array)
		{
			int result = 0;

			foreach (var number in array)
			{
				result += number;
			}

			return result / array.Length;
		}
	}
}
