using System;
using System.Diagnostics;
using System.Net;

namespace L09_ClassWork_2
{
	class Program
	{
		static void Main(string[] args)
		{
			const int length = 20;
			const int maxValue = 100;
			Stopwatch stopwatch = new Stopwatch();

			int[] arraySource = GetSourceArray(length, maxValue);
			int[] arraySortedBubble = GetArraySortedBubble(arraySource);

			Stopwatch.StartNew()
			int[] arraySortedInternal = GetArraySortedBubble(arraySource);
			Stopwatch

			stopwatch.Start();
			BubbleSort(bubbleSortedArray);
			stopwatch.Stop();


			WriteOutArray(arraySource);
			WriteOutArray(arraySortedBubble);
		}

		public static int[] GetSourceArray(int length, int maxValue)
		{
			int[] array = new int[length];
			var random = new Random();

			for (int i = 0; i < array.Length; i++)
			{
				array[i] = random.Next(maxValue);
			}

			return array;
		}

		public static void WriteOutArray(int[] array)
		{
			Console.WriteLine(string.Join(", ", array));
		}

		public static int[] GetArraySortedBubble(int[] sourceArray)
		{
			int[] array = (int[])sourceArray.Clone();

			for (int i = 0; i < array.Length; i++)
			{
				int limit = array.Length - 1 - i;

				for (int j = 0; j < limit; j++)
				{
					if (array[j] > array[j + 1])
					{
						int temp = array[j + 1];
						array[j + 1] = array[j];
						array[j] = temp;
					}
				}

			}

			return array;
		}
	}
}
