using System;

namespace L05_ClassWork_PW
{
	class Program
	{
		[Flags]
		enum Color
		{
			None = 0x0,
			Black = 0x1,
			Blue = 0x2,
			Cyan = 0x4,
			Grey = 0x8,
			Green = 0x10,
			Magenta = 0x20,
			Red = 0x40,
			White = 0x80,
			Yellow = 0x100
		}
		static void Main(string[] args)
		{
			Color allColor = (Color)(0x200 - 1);
			Console.WriteLine(allColor);
			Color favoriteColor = 0;
			Color justColor = 0;
			Console.WriteLine("Choose your 4 color:");
			for (int i = 0; i < 4; i++)
			{
				favoriteColor |= Enum.Parse<Color>(Console.ReadLine());
			}
			justColor = allColor ^ favoriteColor;
			Console.WriteLine($"Favorite colors are: {favoriteColor}");
			Console.WriteLine($"Just colors: {justColor}");
		}
	}
}
