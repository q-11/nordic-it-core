using System;
namespace L15_ClassWork_1_PW1
{
	class Account <T>
	{
		public T Id { get; private set; }
		public string Name { get; private set; }
		public Account(T id, string name)
		{
			Id = id;
			Name = name;
		}
		public void WriteProperties()
		{
			Console.WriteLine(
				$"Id: {Id}\n" +
				$"Name: {Name}\n"
				);
		}
	}
}
