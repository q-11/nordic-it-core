using System;

namespace L11_HomeWork_1
{
	class Program
	{
		static void Main(string[] args)
		{
			ReminderItem exemplier1 = new ReminderItem(DateTimeOffset.Parse("2020-11-20 01:11:00.0000"), "get up!");
			ReminderItem exemplier2 = new ReminderItem(DateTimeOffset.Parse("2020-11-25 18:00:00.0000"), "lesson!");

			exemplier1.WriteProperties();
			exemplier2.WriteProperties();

		}
	}
}
