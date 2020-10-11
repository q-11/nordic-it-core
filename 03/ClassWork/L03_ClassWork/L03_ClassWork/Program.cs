using System;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace L03_ClassWork
{
	class Program
	{
		static void Main(string[] args)
		{
			//object s1 = Console.ReadLine();
			//Console.WriteLine(((string)s1).Length);

			//var a = 3.14f;
			//var b = 1D;
			////var c = 49L;
			//var d = (byte)255;
			//Console.WriteLine(a.GetType());
			//Console.WriteLine(b.GetType());
			//Console.WriteLine(c.GetType());
			//Console.WriteLine(d.GetType());

			//Console.WriteLine($"{default(string)}");

			//dynamic s2 = Console.ReadLine();
			//Console.WriteLine(s2.Length);

			//int? a = null;
			//Console.WriteLine(a);
			//a = 4;
			//Console.WriteLine(a);

			//int? a = 5;
			//Console.WriteLine(a.Value);
			//Console.WriteLine(a.HasValue);

			//string[] trees = new string[3];
			//int[] age = new int[3];
			//for (int i = 0; i < trees.Length; i++)
			//{
			//	Console.Write("Введите название дерева ");
			//	string Input = Console.ReadLine();
			//	trees[i] = Console.ReadLine();
			//	Console.WriteLine("Введите возраст дерева " + trees[i] + " ");
			//	age[i] = int.Parse(Console.ReadLine());
			//}
			//for (int i = 0; i < trees.Length; i++) {
			//	Console.WriteLine(trees[i] + " - возраст в годах " + age[i]);
			//}

			Console.WriteLine("Нажмите клавишу");
			ConsoleKeyInfo keyInfo = Console.ReadKey();

			Console.WriteLine($"Key char: {keyInfo.KeyChar}");
			ConsoleModifiers modifiers = keyInfo.Modifiers;

			ConsoleColor fgColor = Console.ForegroundColor;
			ConsoleColor bgColor = Console.BackgroundColor;
			Console.ForegroundColor = ConsoleColor.Green;
			Console.BackgroundColor = ConsoleColor.Yellow;
			Console.SetCursorPosition(left: 10, top: 10);

			Console.InputEncoding = Encoding.UTF8;
			Console.OutputEncoding = Encoding.UTF8;
			Console.Title = "qwerty";

			string s = "10";
			s.PadRight(4);

			if ((modifiers & ConsoleModifiers.Alt) != 0)
				Console.WriteLine("Alt pressed");
			Console.ForegroundColor = fgColor;
			Console.BackgroundColor = bgColor;
			
			if ((modifiers & ConsoleModifiers.Shift) != 0)
				Console.WriteLine("Shift pressed");

			if ((modifiers & ConsoleModifiers.Control) != 0)
				Console.WriteLine("Ctrl pressed");

			Console.ReadLine();

		}
	}
}
