using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Reflection.Metadata;

namespace L10_ClassWork_PW1
{
	class Program
	{
		static void Main(string[] args)
		{
			var pet1 = new Pet()
			{
				Name = "Pushistik",
				Kind = PetKind.Cat,
				Sex = 'M',
				DateOfBirth = DateTimeOffset.Parse("2013-11-06 20:20:15.5438")
			};

			pet1.SetBirthPlace("Saint-Petersburg");

			Console.WriteLine(pet1.GetDescription());

			pet1.UpdateProperties(pet1.Name = "Alesha");

			Console.WriteLine(pet1.GetDescription());

			var pet2 = new Pet();
			pet2.Name = "Bob";
			pet2.Kind = PetKind.Dog;
			pet2.Sex = 'M';
			pet2.DateOfBirth = DateTimeOffset.Parse("2012-11-06 20:20:15.5438");
			pet2.SetBirthPlace("Moscow");

			Console.WriteLine(pet2.GetDescription(false));

			pet1.UpdateProperties(pet2.Sex = 'F', pet2.Name = "Glatya", pet2.Kind = PetKind.Mouse);

			Console.WriteLine(pet2.GetDescription(false));

			var pet3 = new Pet("LV", DateTimeOffset.Parse("2012-11-06 20:20:15.5438"), "Moscow", 'F', PetKind.Cat);
			Console.WriteLine(pet3.GetDescription(false));

		}

	}
}
