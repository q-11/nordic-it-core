using System;

namespace L11_HomeWork_1
{
	class ChatReminderItem : ReminderItem
	{
		public string ChatName { get; set; }
		public string AccountName { get; set; }
		public ChatReminderItem(DateTimeOffset date, string message, string chatName, string accountName) : base(date, message)
		{
			ChatName = chatName;
			AccountName = accountName;
		}
		public new void WriteProperties()
		{
			Console.WriteLine($"ChatReminderItem:" +
				$"\nAlarmDate: {AlarmDate}" +
				$"\nAlarmMessage: {AlarmMessage}" +
				$"\nTimeToAlarm: {TimeToAlarm}" +
				$"\nIsOutdated: {IsOutdated}" +
				$"\nChatName: {ChatName}" +
				$"\nAccountName: {AccountName}" +
				"\n");
		}
	}
}