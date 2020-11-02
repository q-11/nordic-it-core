using System;
using System.Collections.Generic;
using System.Linq;

namespace L08_ClassWork_Dictionary
{
	class Program
	{
		static void Main(string[] args)
		{
			var countries = new Dictionary<int, string>(5);
			countries.Add("Москва", "России");
			countries.Add("Сухум", "Абхазии");
			countries.Add(3, "Австрии");
			countries.Add(4, "Беларуси");
			countries.Add(5, "Армении");

			int index = (new Random().Next(countries.Count));
			KeyValuePair<int, string> kvp = countries.ElementAt(index);

			Console.Write($"Введите столицу {kvp.Value}: ");
			string input = Console.ReadLine();


			if ()

			
			//foreach (KeyValuePair<string, string> country in countries)
			//{
			//	Console.WriteLine($"{country.Key} - {country.Value}");
			//}



			//var capitals = new Dictionary<int, string>(5);
			//capitals.Add(1, "Москва");
			//capitals.Add(2, "Сухум");
			//capitals.Add(3, "Вена");
			//capitals.Add(4, "Минск");
			//capitals.Add(5, "Ереван");
			//countries.Add(1, "Great Britain"); Нельзя добавлять элементы с уже существующими значениями. Незя!!!

		}

	}
}
