using System;

namespace L07_HomeWork_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите строку из нескольких слов:");
			string[] words;

			do
			{
				string input = Console.ReadLine();
				words = input.ToLower().Split(' ');
				int number = 0;
				bool succses = Int32.TryParse(input, out number);

				if (succses == true)
				{
					Console.WriteLine("Вы ввели число! Попробуйте еще раз:");
					continue;
				}
				
				else if (words.Length < 2)
				{
					Console.WriteLine("Слишком мало слов :( Попробуйте ещё раз:");
					continue;
				}

				else
				{
					number = 0;

					for (int i = 0; i < words.Length; i++)
					{
						if (words[i].StartsWith("а"))
						{
							number++;
						}
					}

					Console.WriteLine($"Количество слов, начинающихся с буквы 'А': " + number);
					break;
				}

			} while (true);

		}
	}
}
