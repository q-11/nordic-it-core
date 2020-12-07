using System;

namespace Calculator.Operation
{
	static public class CircleOperation
	{
		static double CalculatePerimeter(double radius)
		{
			return Math.Pow(radius, 2) * Math.PI;
		}
		static double CalculateSquare(double radius)
		{
			return radius * 2 * Math.PI;
		}
	}
}
