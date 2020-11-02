using System;
using System.Collections.Generic;

namespace L08_HomeWork_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите строку со скобками:");
			string line = string.Empty;
			bool result;

			do
			{
				line = Console.ReadLine();
				result = CheckLine(line);
				WriteIntermediateResult(result);
			} while (CheckLine(line) != true);

			result = CheckBrackets(line);

			WriteResult(result, line);

			static bool CheckLine(string line)
			{
				for(int i = 0; i != line.Length; i++)
				{
					if (line[i] == '(' || line[i] == ')' || line[i] == '[' || line[i] == ']')
					{
						return true;
					}
					else
					{
						return false;
					}
				}
				return true;
			}

			static bool CheckBrackets(string line)
			{
				char[] opening = { '(', '[' };
				char[] closing = { ')', ']' };

				Stack<char> brackets = new Stack<char>();
				foreach (var symbol in line)
				{
					int i;
					if (Array.IndexOf(opening, symbol) > -1)
					{
						brackets.Push(symbol);
					}
					else if ((i = Array.IndexOf(closing, symbol)) > -1)
					{
						if (brackets.Count == 0 || brackets.Pop() != opening[i])
						{
							return false;
						}
					}
				}
				return brackets.Count == 0;
			}

			static void WriteResult(bool result, string line)
			{
				if (result == true)
				{
					Console.WriteLine($"{line} - верно");
					
				}
				else
				{
					Console.WriteLine($"{line} - неверно");
				}
			}

			static void WriteIntermediateResult(bool result)
			{
				if (result == false)
				{
					Console.WriteLine("Ваша строка должна содержать только круглые или квадратные скобки!");
				}
			}

		}
	}
}