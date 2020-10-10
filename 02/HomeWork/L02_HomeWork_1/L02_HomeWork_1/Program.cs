using System;
namespace L02_HomeWork_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите число 1: ");
			string input = Console.ReadLine();
			float value1 = float.Parse(input);
			Console.Write("Введите число 2: ");
			input = Console.ReadLine();
			float value2 = float.Parse(input);
			Console.WriteLine($"Сумма {value1 + value2}");
			Console.WriteLine($"Разность {value1 - value2}");
			Console.WriteLine($"Частное {value1 / value2}");
			Console.WriteLine($"Произведение {value1 * value2}");
			Console.ReadKey();

		}
	}
}
