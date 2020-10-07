using System;
namespace L02_HomeWork_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите число 1: ");
			string Input = Console.ReadLine();
			float Value1 = float.Parse(Input);
			Console.Write("Введите число 2: ");
			Input = Console.ReadLine();
			float Value2 = float.Parse(Input);
			Console.WriteLine($"Сумма {Value1 + Value2}");
			Console.WriteLine($"Разность {Value1 - Value2}");
			Console.WriteLine($"Частное {Value1 / Value2}");
			Console.WriteLine($"Произведение {Value1 * Value2}");
			Console.ReadKey();

		}
	}
}
