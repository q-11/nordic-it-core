using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace L05_HomeWork_1
{
	enum Figures
	{
		circle = 1,
		triangle = 2,
		rectangle = 3
	}
	class Program
	{
		static void Main(string[] args)
		{
			Figures choce = 0;
			Console.WriteLine("Введите номер одной из фигур (1 - круг, 2 - треугольник, 3 - прямоугольник): ");
			object figure = Enum.Parse(typeof(Figures), Console.ReadLine());
			choce = (Figures)figure;

			string input;
			double perimeter;
			double space;
			double D;
			double A;
			double H;

			try
			{
				switch (choce)
				{
					case Figures.circle:
						Console.Write("Введите диаметр круга: ");
						input = Console.ReadLine();
						D = double.Parse(input);

						if (D > 0)
						{
							perimeter = (D / 2) * (Math.PI * 2);
							space = Math.Pow((D / 2), 2) * Math.PI;
							Console.WriteLine("Периметр круга: " + perimeter);
							Console.WriteLine("Площадь круга: " + space);
						}

						else
						{
							Console.WriteLine("Диаметр не может быть <= 0");
						}

						break;
					case Figures.triangle:
						Console.Write("Введите длину стороны теугольника: ");
						input = Console.ReadLine();
						A = double.Parse(input);

						if (A > 0)
						{
							perimeter = (A * 3);
							space = (Math.Pow(A, 2) * Math.Sqrt(3)) / 4;
							Console.WriteLine("Периметр треугольника: " + perimeter);
							Console.WriteLine("Площадь треугольника: " + space);
						}

						else
						{
							Console.WriteLine("Сторона не может быть <= 0");
						}

						break;
					case Figures.rectangle:
						Console.Write("Введите длину стороны прямоугольника: ");
						input = Console.ReadLine();
						A = double.Parse(input);
						Console.Write("Введите высоту стороны прямоугольника: ");
						input = Console.ReadLine();
						H = double.Parse(input);

						if (A > 0 && H > 0)
						{
							perimeter = (A * 2) + (H * 2);
							space = A * H;
							Console.WriteLine("Периметр прямоугольника: " + perimeter);
						}

						else 
						{
							Console.WriteLine("Сторона не может быть <= 0");
						}

						break;
				}
			}
			catch (FormatException)
			{
				Console.WriteLine("Format Exception error!");
			}
		}
	}
}
