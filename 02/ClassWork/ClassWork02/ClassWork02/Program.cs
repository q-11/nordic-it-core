using System;
using System.Dynamic;

namespace ClassWork02
{
	class Program
	{
			static void Main(string[] args)
		{
			//char letter = 'A';
			//Console.WriteLine(letter);
			//string name = "Bob";
			//Console.WriteLine(name);
			//var i = 0x0000001;
			//float pi = 3.1415f;
			//Console.WriteLine(i + pi);
			//int parseValue = int.Parse("232323");
			//parseValue = parseValue + 1;
			//Console.WriteLine(parseValue);
			Console.Write("Введите ваш возраст: ");
			string inputAge = Console.ReadLine();
			int age = int.Parse(inputAge);
			Console.WriteLine($"Ваш возраст через 10 лет: {age + 10}");
		}
	}
}