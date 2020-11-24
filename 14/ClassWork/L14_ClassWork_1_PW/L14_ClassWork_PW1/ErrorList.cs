using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace L14_ClassWork_PW1
{
	class ErrorList : IEnumerable<string>, IDisposable
	{
		public static string OutputPrefixFormat{ get; set; }

		static ErrorList()
		{
			OutputPrefixFormat = "MMMM d, yyyy (h: mm tt)";
		}

		public string _category;
		public string Category { get; }
		private List<string> Errors = new List<string>();
		public ErrorList(string category)
		{
			_category = Category;
		}
		public void Add(string errorMessage)
		{
			Errors.Add(errorMessage);
		}
		public void Dispose()
		{
			if (Errors != null)
			{
				Errors.Clear();
				Errors = null;
			}
		}
		public IEnumerator<string> GetEnumerator()
		{
			return Errors.GetEnumerator();
		}
		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
		public void WriteToConsole()
		{
			foreach (string error in Errors)
			{
				Console.WriteLine(DateTime.Now.ToString(OutputPrefixFormat) + " " + error);
			}
			
		}
	}
}