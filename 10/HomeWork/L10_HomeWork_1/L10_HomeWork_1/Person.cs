using System;

namespace L10_HomeWork_1
{
	class Person
	{
		private byte _age;

		public string Name;

		public byte Age
		{
			get { return _age; }
			set
			{
				if (value == 0 || value >= 150)
				{
					throw new Exception("Age should be less or equals to 150");
				}

				_age = value;
			}
		}
		public byte AgeInFourYears
		{
			get
			{ return (Age += 4); }
		}

		public string PropertiesString
		{
			get
			{
				return $"Name: {Name}, age in 4 years: {AgeInFourYears}";
			}
		}
	}
}
