using System;

namespace L02_HomeWork_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите число 1: ");
			string Value = Console.ReadLine();
			float Value1 = float.Parse(Value);
			Console.Write("Введите число 2: ");
			Value = Console.ReadLine();
			float Value2 = float.Parse(Value);
			Console.WriteLine("Возможные операции:\nсложение\nвычитание\nумножение\nделение\nостаток от деления\nвозведение в степень");
			string Operation = Console.ReadLine();
			if (Operation == "сложение")
			{
				Console.WriteLine(Value1 + Value2);
			}
			else if (Operation == "вычитание")
			{
				Console.WriteLine(Value1 - Value2);
			}
			else if (Operation == "умножение")
			{
				Console.WriteLine(Value1 * Value2);
			}
			else if (Operation == "деление")
			{
				Console.WriteLine(Value1 / Value2);
			}
			else if (Operation == "остаток от деления")
			{
				Console.WriteLine(Value1 % Value2);
			}
			else if (Operation == "возведение в степень")
			{
				float outcome = 1;
				int counter = 0;
				while (Value2 != counter)
				{
					outcome = outcome * Value1;
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