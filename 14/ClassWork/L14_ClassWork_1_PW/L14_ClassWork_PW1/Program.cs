using System;

namespace L14_ClassWork_PW1
{
	class Program
	{
		static void Main(string[] args)
		{
			System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");

			ErrorList.OutputPrefixFormat = "MMMM d, yyyy (h: mm tt)";
			using var errorList = new ErrorList("Program Errors");
			errorList.Add("1");
			errorList.Add("2");

			errorList.WriteToConsole();
		}
	}
}
