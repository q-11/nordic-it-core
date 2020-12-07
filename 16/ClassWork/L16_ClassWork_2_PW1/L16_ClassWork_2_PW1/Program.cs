using System;

namespace L16_ClassWork_2_PW1
{
	class Program
	{
		static void Main(string[] args)
		{
			var figure1 = new Circle(1.5);
 
			Func<double, double> CalculateSquare = radius => Math.Pow(radius, 2) * Math.PI;

			Console.WriteLine(figure1.Calculate(CalculateSquare));
			Console.WriteLine(figure1.Calculate(radius => radius * 2 * Math.PI));
		}
	}
}
