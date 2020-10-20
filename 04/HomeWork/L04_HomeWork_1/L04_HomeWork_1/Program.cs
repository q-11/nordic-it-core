using System;

namespace L04_HomeWork_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Какой объем сока необходимо упаковать?");
			string input = Console.ReadLine();
			float value = float.Parse(input);

			float ct20 = 0;
			float ct5 = 0;
			float ct1 = 0;

			ct20 = value / 20;
			if (ct20 >= 1)
			{
				Console.WriteLine($"Количество контейнеров 20л: {Math.Floor(ct20)}");
			}
			value = value % 20;

			ct5 = value / 5;
			if (ct5 >= 1)
			{
				Console.WriteLine($"Количество контейнеров 5л: {Math.Floor(ct5)}");
			}
			value = value % 5;

			ct1 = value / 1;
			if (ct1 != 0)
			{
				Console.WriteLine($"Количество контейнеров 1л: {Math.Ceiling(ct1)}");
			}

		}
	}
}
