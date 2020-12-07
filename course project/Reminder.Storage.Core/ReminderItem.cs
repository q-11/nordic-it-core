using System;

namespace Reminder.Storage.Core
{
	public class ReminderItem
	{
		public Guid Id { get; }
		public ReminderItemChat Chat { get; }
		public string ContactId { get; set; }

		public DateTimeOffset Date;

		public string Message;
		public TimeSpan TimeToAlarm => Date.Subtract(DateTimeOffset.Now);
		public bool IsTimeToSend => TimeToAlarm <= TimeSpan.Zero;
		public ReminderItemStatus Status { set; get; }
		public ReminderItem(Guid id, DateTimeOffset date, string message, string contactId)
		{
			Chat = ReminderItemChat.Telegram;
			Id = id;
			Date = date;
			Message = message;
			ContactId = contactId;
		}
		public ReminderItem(DateTimeOffset date, string message, string contactId) : this(Guid.NewGuid(), date, message, contactId){}

	}
}
