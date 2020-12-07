using System;
namespace L15_ClassWork_2_delegate
{
	class Program
	{
		public delegate int PerformCalculator(int a, int b);
		static void Main(string[] args)
		{
			var calc = new SimpleCalculator();

			PerformCalculator performCalculaton1;
			performCalculaton1 = calc.Sum;

			PerformCalculator performCalculaton2;
			performCalculaton2 = calc.Multiply;

			performCalculaton2 = (PerformCalculator)Delegate.Combine(performCalculaton1, performCalculaton2);

		}
		public static void DoCalculation(int a, int b, PerformCalculator calculate)
		{
			int result = calculate(a, b);
			Console.WriteLine($"Result: {result}");
		}
	}
}
