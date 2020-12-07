using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Reminder.Storage.Core.Tests
{
	[TestClass]
	public class ReminderItemTests
	{
		[TestMethod]
		public void Constructor_Initializes_Id_With_Not_Empty_Guid()
		{
			//preparing
			//test run

			ReminderItem item = new ReminderItem(DateTimeOffset.MinValue, null, null);

			//checking the results

			Assert.AreNotEqual(Guid.Empty, item.Id);
		}
		[TestMethod]
		public void Constructor_Initializes_Explicit_Parameters()
		{
			//preparing
			Guid id = Guid.NewGuid();
			DateTimeOffset date = DateTimeOffset.Parse("2020-01-01 12:00");
			const string message = "msg";
			const string contactId = "id";

			//test run

			var item = new ReminderItem(id, date, message, contactId);

			//checking the results

			Assert.AreNotEqual(id, item.Id);
			Assert.AreEqual(date, item.Date);
			Assert.AreEqual(message, item.Message);
			Assert.AreEqual(contactId, item.ContactId);
		}
		[DataTestMethod]
		[DataRow("1000-01-01 00:00")]
		[DataRow("3000-01-01 00:00")]
		public void TimeToAlarm_Positive_For_Future_Event_And_Vise_Varsa(string stringDate)
		{
			//preparing
			DateTimeOffset date = DateTimeOffset.Parse(stringDate);

			//test run
			var item = new ReminderItem(date, null, null);

			//checking the results


		}
	}
}
