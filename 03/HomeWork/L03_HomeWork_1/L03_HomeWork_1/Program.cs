using System;

namespace L03_HomeWork_1
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] names = new string[3];
			int[] age = new int[3];
			for (int i = 0; i < names.Length; i++)
			{
				Console.Write($"Enter {i + 1} name ");
				names[i] = Console.ReadLine();
				Console.WriteLine($"How old is {names[i]} ?");
				age[i] = int.Parse(Console.ReadLine());
			}
			for (int i = 0; i < names.Length; i++)
			{
				Console.WriteLine($"Name: {names[i]}" + $" age in 4 years: {age[i] + 4}");
			}
		}
	}
}
