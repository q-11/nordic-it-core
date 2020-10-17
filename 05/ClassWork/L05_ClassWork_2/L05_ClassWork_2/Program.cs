using System;
using System.Net.Mail;

namespace L05_ClassWork_2
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.Write("Введите срок действия договора: ");
			//string input = Console.ReadLine();
			//int inputYears = int.Parse(input);
			//string line = "Договор аренды оформлен на период длительностью ";

			//if (inputYears > 30 || inputYears < 1)
			//{
			//	Console.WriteLine(">30");
			//	return;
			//}
			//switch (inputYears)
			//{
			//	case 1:
			//	case 21:
			//		Console.WriteLine(line + inputYears + " год");
			//		break;
			//	case 2:
			//	case 3:
			//	case 4:
			//	case 22:
			//	case 23:
			//	case 24:
			//		Console.WriteLine(line + inputYears + " года");
			//		break;
			//	default:
			//		Console.WriteLine(line + inputYears + " лет");
			//		break;
			//}


			//if (inputYears > 30)
			//{
			//	Console.WriteLine(">30");
			//}
			//else if ((inputYears < 5 || inputYears > 20) & (inputYears != 1 || inputYears != 21))
			//{
			//	Console.WriteLine(line + inputYears + " года");
			//}
			//else if (inputYears > 5 || inputYears < 20 & (inputYears != 1 || inputYears != 21))
			//{
			//	Console.WriteLine(line + inputYears + " лет");
			//}
			//else if (inputYears == 1 || inputYears == 21)
			//{
			//	Console.WriteLine(line + inputYears + " год");
			//}

			//Console.WriteLine(int.Parse(
			//	Console.ReadLine()) < 50
			//	? "Введенное число < 50"
			//	: "Введенное число >= 50");

			string str = Console.ReadLine();
			int a = int.Parse(str);
			Console.WriteLine($"{a * a}");
		}
	}
}

