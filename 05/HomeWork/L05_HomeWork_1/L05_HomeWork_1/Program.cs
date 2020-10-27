using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace L05_HomeWork_1
{
	enum Figures
	{
		Circle = 1, 
		Triangle = 2, 
		Rectangle = 3 
	}
	class Program
	{
		static void Main(string[] args)
		{
			Figures choice = 0;
			Console.WriteLine("Введите номер одной из фигур (1 - круг, 2 - треугольник, 3 - прямоугольник): ");
			object figure = Enum.Parse(typeof(Figures), Console.ReadLine());
			choice = (Figures)figure;

			string input;
			double perimeter;
			double space;
			double diameter;
			double sideLength;
			double height;

			try
			{
				switch (choice)
				{
					case Figures.Circle:
						Console.Write("Введите диаметр круга: ");
						input = Console.ReadLine();
						diameter = double.Parse(input);

						if (diameter > 0)
						{
							perimeter = (diameter / 2) * (Math.PI * 2);
							space = Math.Pow((diameter / 2), 2) * Math.PI;
							Console.WriteLine("Периметр круга: " + perimeter);
							Console.WriteLine("Площадь круга: " + space);
						}

						else
						{
							Console.WriteLine("Диаметр не может быть <= 0");
						}

						break;
					case Figures.Triangle:
						Console.Write("Введите длину стороны теугольника: ");
						input = Console.ReadLine();
						sideLength = double.Parse(input);

						if (sideLength > 0)
						{
							perimeter = (sideLength * 3);
							space = (Math.Pow(sideLength, 2) * Math.Sqrt(3)) / 4;
							Console.WriteLine("Периметр треугольника: " + perimeter);
							Console.WriteLine("Площадь треугольника: " + space);
						}

						else
						{
							Console.WriteLine("Сторона не может быть <= 0");
						}

						break;
					case Figures.Rectangle:
						Console.Write("Введите длину стороны прямоугольника: ");
						input = Console.ReadLine();
						sideLength = double.Parse(input);
						Console.Write("Введите высоту стороны прямоугольника: ");
						input = Console.ReadLine();
						height = double.Parse(input);

						if (sideLength > 0 && height > 0)
						{
							perimeter = (sideLength * 2) + (height * 2);
							space = sideLength * height;
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
