using System;

namespace L14_ClassWork_2_StaticDemoClass
{
	class Program
	{
		static void Main(string[] args)
		{
			var weight1 = new StaticDemoClass();
			weight1.Weight = 12;

			var weight2 = new StaticDemoClass();
			weight2.Weight = 10;

			Console.WriteLine(StaticDemoClass.SumWeight);

		}
	}
}
