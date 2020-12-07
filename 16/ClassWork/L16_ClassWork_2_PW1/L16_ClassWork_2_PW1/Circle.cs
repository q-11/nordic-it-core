using System;

namespace L16_ClassWork_2_PW1
{
	public sealed class Circle
	{
		private double _radius;
		public Circle(double radius)
		{
			_radius = radius;
		}
		public double Calculate(Func<double, double> operation)
		{
			return operation(_radius);
		}
	}
}
