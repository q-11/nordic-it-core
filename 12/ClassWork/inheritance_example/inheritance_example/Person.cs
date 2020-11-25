using System;
namespace inheritance_example
{
	public class Person
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public DateTimeOffset Birthday { get; set; }
		public byte Age
		{
			get
			{
				return GetAge();
			}
		}
		public Person(string name, string surname, DateTimeOffset birthday)
		{
			Name = name;
			Surname = surname;
			Birthday = birthday;
		}
		public byte GetAge()
		{
			TimeSpan liveTime = DateTimeOffset.Now.Subtract(Birthday);
			byte years = (byte)Math.Floor(liveTime.TotalDays / 365.242);
			return years;
		}
		public void WriteDescription()
		{
			Console.WriteLine($"{Name} {Surname} родился {Birthday.ToString("dd.MM.yyyy")}. На данный момент {Age} лет.");
		}
	}
}
