using System;

namespace L06_HomeWork_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите положительное натуральное число не более 2 миллиардов: ");
			while (true)
			{
				string input = Console.ReadLine();
				int number;
				bool success = Int32.TryParse(input, out number);
				if (success == true && Convert.ToInt32(input) > 0)
				{
					char[] numbers = new char [input.Length];
					number = 0;
					for (int i = 0; i < input.Length; i++)
					{
						numbers[i] = input[i];
						if (numbers[i] % 2 == 0)
						{
							number++;
						}
					}
					Console.WriteLine($"Четных чисел: {number}");
					break;
				}
				else
					Console.Write("Вы ввели что-то не то! Попробуйте снова: ");
			}
		}
	}
}
