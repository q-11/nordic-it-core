using System;
namespace L02_HomeWork_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите число 1: ");
			string value = Console.ReadLine();
			float value1 = float.Parse(value);
			Console.Write("Введите число 2: ");
			value = Console.ReadLine();
			float value2 = float.Parse(value);
			Console.WriteLine("Возможные операции:\nсложение\nвычитание\nумножение\nделение\nостаток от деления\nвозведение в степень");
			string Operation = Console.ReadLine();
			if (Operation == "сложение")
			{
				Console.WriteLine(value1 + value2);
			}
			else if (Operation == "вычитание")
			{
				Console.WriteLine(value1 - value2);
			}
			else if (Operation == "умножение")
			{
				Console.WriteLine(value1 * value2);
			}
			else if (Operation == "деление")
			{
				Console.WriteLine(value1 / value2);
			}
			else if (Operation == "остаток от деления")
			{
				Console.WriteLine(value1 % value2);
			}
			else if (Operation == "возведение в степень")
			{
				float outcome = 1;
				int counter = 0;
				while (value2 != counter)
				{
					outcome = outcome * value1;
					counter++;
				}
				Console.WriteLine(outcome);
			}
			else
			{
				Console.WriteLine("Такой операции нет");
			}
		}
	}
}