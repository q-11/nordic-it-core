using System;
using System.Globalization;
using System.Text;


namespace L07_ClassWork_1
{
	class Program
	{
		static void Main(string[] args)
		{
			//string input = Console.ReadLine();
			//double a = double.Parse(input);
			//input = "";
			//input = Console.ReadLine();
			//double b = double.Parse(input);
			//Console.WriteLine(a.ToString(format: "0:#") + " * " + b.ToString(format: "0:#") + " = " + (a * b).ToString(format: "0:#"));
			//Console.WriteLine("{0:0.##} / {1:0.##} = {2:0.##}", a, b, a / b);
			//Console.WriteLine($"{a:0###} - {b:0###} = {a-b:0###}");

			//string a = "test line";

			//Console.WriteLine(a.Contains(" "));
			//Console.WriteLine(a.StartsWith("te"));
			//Console.WriteLine(a.EndsWith("ne"));

			//Console.WriteLine(a.IndexOf("s"));
			//Console.WriteLine(a.LastIndexOf("e"));

			//string word = Console.ReadLine();
			//string letter = Console.ReadLine();

			//string result = word.Replace(letter, "*");
			//Console.WriteLine(result);

			//int indexLetter = 0;
			//do
			//{
			//	indexLetter = word.IndexOf(letter, indexLetter);

			//	if (indexLetter < 0)
			//		break;

			//	Console.WriteLine(indexLetter);
			//	indexLetter++;
			//} while (true);

			//string email = Console.ReadLine();
			//Console.WriteLine(email.ToLower());
			//Console.WriteLine(email.ToUpper());


			//================================
			//string text = "     lorem       ipsum      dolor      sit       amet      ";
			//for (int i = 0; i < text.Length; i++)
			//{
			//	if (text.IndexOf(i) == " ")
			//	text = text 
			//}
			//Console.WriteLine(text.Replace(" ", ""));
			//Console.WriteLine(text.Trim());

			//string text = "     lorem       ipsum      dolor      sit       amet      ";
			//string[] words = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
			//words[1] = words[1].ToUpper();
			//string result = string.Join(" ", words);

			//string[] words = "this is my first example".Split(" ");

			//var exampleBuilder = new StringBuilder(100);
			//foreach (var word in words)
			//{
			//	exampleBuilder
			//		.Append(word)
			//		.Append(" * ");
			//}

			//exampleBuilder.Remove(
			//	exampleBuilder.Length - 2,
			//	2);

			//Console.WriteLine(exampleBuilder.ToString());

			string text = "     lorem       ipsum      dolor      sit       amet      ";
			var resultBuilder = new StringBuilder(text.Length);

			for (int i = 0; i < text.Length; i++)
			{
				resultBuilder.Append(text[i]);
			}

		}
	}
}
