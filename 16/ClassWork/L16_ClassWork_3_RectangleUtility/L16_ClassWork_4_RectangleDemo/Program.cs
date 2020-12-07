using System;
using L16_ClassWork_3_RectangleUtility;

namespace L16_ClassWork_4_RectangleDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			var rect1 = new Rectangle<double>(12.1, 12.2);
			double square = rect1.Calculate((double x, double y) => (double)(x * y));

			Console.WriteLine(double.MaxValue);
			Console.WriteLine(short.MinValue);
			Console.WriteLine(square);
		}
	}
}
