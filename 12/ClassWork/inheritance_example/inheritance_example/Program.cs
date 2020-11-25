using System;

namespace inheritance_example
{
	class Employee : Person
	{
		public int Code { get; set; }
		public Employee(int code, string name, string surname, DateTimeOffset birthday) : base(name, surname, birthday)
		{
			Code = code;
		}
		public new void WriteDescription()
		{
			Console.WriteLine($"{Code}: {Name} {Surname} родился {Birthday.ToString("dd.MM.yyyy")}. На данный момент {Age} лет.");
		}


	}
	class Program
	{
		static void Main(string[] args)
		{
			var person = new Person("Егор", "Верховцев", DateTimeOffset.Parse("2002-06-16"));
			var employee = new Employee(0001, "Егор", "Верховцев", DateTimeOffset.Parse("2001-06-16"));

			person.WriteDescription();
			employee.WriteDescription();
		}

	}
}
