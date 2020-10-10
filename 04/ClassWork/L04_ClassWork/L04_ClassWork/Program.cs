using System;
using System.Globalization;

namespace L04_ClassWork
{
	class Program
	{
		[Flags]
		enum CarType : byte
		{
			None = 0,
			SUV = 1,
			Sedan = 2,
			Truck = 4
		}
		//enum DayTime
		//{
		//	night,
		//	morning,
		//	noon,
		//	evening
		//}
		static void Main(string[] args)
		{
			var myCarType = CarType.Sedan;

			WriteByteValueWithBits((byte)myCarType);

			CarType supportCars =
				CarType.SUV
				| CarType.Sedan
				| CarType.Truck;

			WriteByteValueWithBits((byte)supportCars);

			//var currentDayTime = Enum.Parse(typeof(DayTime), Console.ReadLine());
			//Console.WriteLine((DayTime)((int)currentDayTime + 1));

			//int a = 16;
			//int b;
			//b = a++;
			//Console.WriteLine(a == b);
			//Console.WriteLine(a != b);
			//Console.WriteLine(a > b);
			//Console.WriteLine(a < b);
			//Console.WriteLine(a >= b);
			//Console.WriteLine(a <= b);

			//int a = 10;
			//double b = a;
			//Console.WriteLine(b);

			//double c = 9.8;
			//int d = (int)c;
			//Console.WriteLine(d);

			//int a = int.MaxValue;
			//int b = int.MaxValue;
			//int c = a * b;
			//Console.WriteLine(c);

			//double l = 10.5;

			//Console.WriteLine(Convert.ToInt32(l)); // it will be 10!

			//Console.WriteLine(Math.Round(l, MidpointRounding.ToEven));
			//Console.WriteLine(Math.Round(l, MidpointRounding.AwayFromZero));

			//Console.Write("a = ");
			//string input = Console.ReadLine();
			//double a = double.Parse(input);
			//Console.Write("h = ");
			//input = Console.ReadLine();
			//double h = double.Parse(input);
			//Console.Write("n = ");
			//input = Console.ReadLine();
			//double n = double.Parse(input);
			//double j = 2 * Math.Tan(Math.PI / n);
			//double S1 = ((n * a) / 2) * ((a / j) + Math.Sqrt((Math.Pow(x: h, y: 2)) + Math.Pow(x: a / j, y: 2)));
			//double S2 = ((n * a) / 2 * Math.Sqrt((Math.Pow(x: h, y: 2)) + Math.Pow(x: a / j, y: 2)));
			//double V = (((h * n) * Math.Pow(x: a, y: 2))) / (12 * (j / 2));
			//Console.WriteLine(S1);
			//Console.WriteLine(S2);
			//Console.WriteLine(V);


			//string delimiter =
			//	CultureInfo.
			//		InvariantCulture.
			//		NumberFormat.
			//		NumberDecimalSeparator;
			//Console.WriteLine("Enter floating number " + $"use {delimiter} as number decimal separator:");
			//string sf = "3.92837461";
			//float a = float.Parse(floatA, CultureInfo.InvariantCulture);
			//Console.WriteLine(a);
		}
		static void WriteByteValueWithBits(byte value)
		{
			Console.WriteLine(
				"0x{0}\t({1})\t{2}",
				value.ToString("X").PadLeft(2, '0'),
				Convert.ToString(value, 2).PadLeft(8, '0'),
				value.ToString().PadLeft(3, '0'));
		}
	}
}
