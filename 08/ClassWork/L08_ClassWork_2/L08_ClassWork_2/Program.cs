using System;
using System.Collections.Generic;

namespace L08_ClassWork_2
{
	class Program
	{
		static void Main(string[] args)
		{
			var intList = new List<double> { };
			intList.Clear();
			string input;
			double value;

			do
			{
				input = Console.ReadLine();
				if (input == "stop" && intList.Count > 2)
				{
					Console.WriteLine("Введите хотя бы 2 числа!");
					break;
				}

				else if (!double.TryParse(input, out double number))
				{
					Console.WriteLine("Вы можете вводить только числа!");
					continue;
				}

				else
				{
					value = double.Parse(input);
					intList.Add(value);
				}
			} while (true);

			double average = 0;
			double sum = 0;

			foreach (double valueInList in intList)
			{
				sum += valueInList;
				average++;
			}
			average =  sum / average;
			Console.WriteLine(average);
			Console.WriteLine(sum);



			//intList.RemoveAt(1);
			//intList.Insert(1, 21);

			//int[] intArray = new[] { 50, 60 };
			//intList.AddRange(intArray);

			//string output = string.Join(", ", intList);


			//if (intList.Count == 0)
			//	Console.WriteLine("Список intList пуст");
			//Console.WriteLine(output);
		}
	}
}
