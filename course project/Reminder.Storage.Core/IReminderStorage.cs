using System;
using System.Collections.Generic;

namespace Reminder.Storage.Core
{
	public interface IReminderStorage
	{
		//add
		void Add(ReminderItem reminderItem);

		//update
		void Update(ReminderItem reminderItem);

		//get
		ReminderItem Get(Guid Id);

		//get list
		List<ReminderItem> GetList(IEquatable<ReminderItemStatus> statuses, int count = -1, int startPosition = 0);
	}
}
