using System.Diagnostics;

namespace L15_ClassWork_2_delegate
{
	class SimpleCalculator
	{
		public int Sum(int x, int y)
		{
			Debug.WriteLine($"{nameof(Sum)} called");
			return x + y;
		}
		public int Multiply(int x, int y)
		{
			Debug.WriteLine($"{nameof(Multiply)} called");
			return x * y;
		}
	}
}
