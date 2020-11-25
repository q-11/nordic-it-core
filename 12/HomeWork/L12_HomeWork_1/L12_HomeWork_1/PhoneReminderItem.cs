using System;

namespace L11_HomeWork_1
{
	internal class PhoneReminderItem : ReminderItem
	{
		public string PhoneNumber { get; set; }
		public PhoneReminderItem(DateTimeOffset date, string message, string phoneNumber) : base(date, message)
		{
			PhoneNumber = phoneNumber;
		}
		public new void WriteProperties()
		{
			Console.WriteLine($"PhoneReminderItem:" +
				$"\nAlarmDate: {AlarmDate}" +
				$"\nAlarmMessage: {AlarmMessage}" +
				$"\nTimeToAlarm: {TimeToAlarm}" +
				$"\nIsOutdated: {IsOutdated}" +
				$"\nPhoneNumber: {PhoneNumber}" +
				"\n");
		}
	}
}