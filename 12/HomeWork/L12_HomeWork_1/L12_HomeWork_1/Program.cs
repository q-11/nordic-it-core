using System;

namespace L11_HomeWork_1
{
	class Program
	{
		static void Main(string[] args)
		{
			var exemplier1 = new ReminderItem(DateTimeOffset.Parse("2020-11-25 19:00:00.0000"), "Lesson!");
			var exemplier2 = new PhoneReminderItem(DateTimeOffset.Parse("2020-11-20 18:00:00.0000"), "Call Jack!", "84952638866");
			var exemplier3 = new ChatReminderItem(DateTimeOffset.Parse("2020-11-30 07:00:00.0000"), "Send time sheet!", "Work issues", "Boss");

			exemplier1.WriteProperties();
			exemplier2.WriteProperties();
			exemplier3.WriteProperties();
		}
	}
}