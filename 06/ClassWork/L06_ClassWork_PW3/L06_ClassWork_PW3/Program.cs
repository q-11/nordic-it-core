using System;
using System.Net.Http.Headers;

namespace L06_ClassWork_PW3
{
	class Program
	{
		static void Main(string[] args)
		{
			var marks = new[]
			{
				new [] { 2, 3, 3, 2, 3},
				new [] { 2, 4, 5, 3},
				null,
				new [] { 5, 5, 5, 5},
				new [] { 4 }
			};

			string notation = "The average mark for day ";
			float averageWeek = 0;
			int totalMarks = 0;

			for (int i = 0; i < marks.Length; i++)
			{
				float averageDay = 0;

				if (marks[i] == null)
				{
					Console.WriteLine(notation + (i + 1) + ": N/A");
					continue;
				}

				totalMarks += marks[i].Length;

				for (int j = 0; j < marks[i].Length; j++)
				{
					averageDay += marks[i][j];
					averageWeek += marks[i][j];
				}

				Console.WriteLine(notation + (i + 1) + ": " + (averageDay / marks[i].Length));
			}

			Console.WriteLine(averageWeek);
		}
	}
}
