using System;

namespace L15_ClassWork_1_PW1
{
	class Program
	{
		static void Main(string[] args)
		{
			var exemplier1 = new Account<int>(100, "George");
			var exemplier2 = new Account<string>("101", "Max");
			var exemplier3 = new Account<Guid>(Guid.Parse("7162f026-0988-4772-adcc-6f5444baba08"), "Jack");

			exemplier1.WriteProperties();
			exemplier2.WriteProperties();
			exemplier3.WriteProperties();


		}
	}
}
