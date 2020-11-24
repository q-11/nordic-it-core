﻿namespace L14_ClassWork_2_StaticDemoClass
{
	class StaticDemoClass
	{
		private static int _sum = 0;
		public static int SumWeight { get { return _sum; } }

		private int _weight;
		public int Weight
		{
			set
			{
				_sum = _sum - _weight + value;
				_weight = value;
			}
			get { return _weight; }
		}
	}
}
