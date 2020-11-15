using System;
using System.Net.Cache;

namespace L10_HomeWork_1
{

	class Program
	{
		static void Main(string[] args)
		{
			const byte number = 3;
			Person[] persons = new Person[number];
			for (int i = 0; i < persons.Length; i++)
			{
				persons[i] = new Person();
				Console.Write($"Enter name {i + 1}: ");
				string input = Console.ReadLine();
				persons[i].Name = input;

				Console.Write($"Enter age {i + 1}: ");

				do
				{

					try
					{
						input = Console.ReadLine();
						persons[i].Age = Byte.Parse(input);
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message + " Try again:");
					}
				} while (persons[i].Age == 0);

			}

			for (int i = 0; i != persons.Length; i++)
			{
				Console.WriteLine(persons[i].PropertiesString);
			}
		}
	}
}
