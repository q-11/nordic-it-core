using System;

namespace L05_ClassWork
{
	enum DaysOfWeek
	{
		Monday,
		Tuesday,
		Wednesday
	}
	[Flags]
	enum Month
	{
		None = 0x0,
		January = 0x1,
		Febrauary = 0x2,
		March = 0x4,
		April = 0x8,
		May = 0x10,
		June = 0x20,
		July = 0x40
	}
	class Program
	{
		static void Main(string[] args)
		{
			Month springMonth;
			springMonth = 0;
			springMonth |= Month.March;
			springMonth |= Month.April;
			springMonth |= Month.May;

			Console.WriteLine($"Spring months are: {springMonth}");

			bool isJanuarySpringMonth =
				(springMonth & Month.January) > 0;

			bool isMaySpringMonth =
				(springMonth & Month.May) > 0;
			Console.WriteLine(isMaySpringMonth);
			Console.WriteLine(isJanuarySpringMonth);

			Month allMonth = (Month)(0x80 - 1);
			Month notSpringMonth = allMonth ^ springMonth;
			//notSpringMonth ^= Month.January;
			//notSpringMonth ^= Month.Febrauary;
			//notSpringMonth ^= Month.June;
			//notSpringMonth ^= Month.July;

			Console.WriteLine($"Not spring month {notSpringMonth}");


		}
	}
}
