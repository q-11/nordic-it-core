using System;

namespace L10_ClassWork_PW1
{
	public enum PetKind { Mouse, Cat, Dog }
	class Pet
	{
		public Pet() { }
		public Pet(string name, DateTimeOffset dateOfBirth, string birthPlace, char sex, PetKind kind)
		{
			Name = name;
			DateOfBirth = dateOfBirth;
			_birthPlace = birthPlace;
			Sex = sex;
			Kind = kind;
		}

		private string _birthPlace;
		private char _sex;
		private byte _age;

		public PetKind Kind;
		public string Name;

		public DateTimeOffset DateOfBirth;
		public byte GetAge()
		{
			TimeSpan liveTime = DateTimeOffset.Now.Subtract(DateOfBirth);
			return (byte)Math.Floor(liveTime.TotalDays / 365.242);
		}
		public char Sex
		{
			get { return _sex; }
			set
			{
				if (value != 'M' && value != 'F' && value != 'm' && value != 'f')
					throw new Exception("Sex should be one of two options: M/F.");

				_sex = char.ToUpper(value);
			}
		}
		public string ShortDiscription
		{
			get
			{
				return $"{Name} {GetAge()} years old.";
			}
		}
		public string Description
		{
			get
			{
				return $"{Name} is a {Kind} ({Sex}) of {GetAge()} years old. Burn in {_birthPlace}.";
			}
		}
		public string GetDescription(bool isShort = false)
		{
			return isShort
				? ShortDiscription
				: Description;
		}
		public void SetBirthPlace(string birthPlace)
		{
			if (birthPlace == null)
			{
				throw new ArgumentNullException(nameof(birthPlace));
			}

			if (_birthPlace != null)
			{
				throw new Exception("Birth place cannot be overwritten!");
			}
			_birthPlace = birthPlace;
		}
		public void UpdateProperties(string name)
		{
			Name = name;
		}
		public void UpdateProperties(char sex, string name, PetKind kind)
		{
			Name = name;
			Sex = sex;
			Kind = kind;
		}
	}
}
