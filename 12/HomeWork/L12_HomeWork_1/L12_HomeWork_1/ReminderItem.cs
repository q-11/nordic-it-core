using System;

namespace L11_HomeWork_1
{
	class ReminderItem
	{
		public DateTimeOffset AlarmDate;
		public string AlarmMessage;
		public TimeSpan TimeToAlarm
		{
			get
			{
				return AlarmDate.Subtract(DateTimeOffset.Now);
			}
		}
		public bool IsOutdated
		{
			get
			{
				if (TimeToAlarm <= TimeSpan.Zero)
				{
					return true;
				}
				return false;
			}
		}
		public ReminderItem(DateTimeOffset date, string message)
		{
			AlarmDate = date;
			AlarmMessage = message;
		}
		public virtual void WriteProperties()
		{
			Console.WriteLine($"ReminderItem:" +
				$"\nAlarmDate: {AlarmDate}" +
				$"\nAlarmMessage: {AlarmMessage}" +
				$"\nTimeToAlarm: {TimeToAlarm}" +
				$"\nIsOutdated: {IsOutdated}" +
				"\n");
		}
	}
}