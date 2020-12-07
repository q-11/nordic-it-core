using System;

namespace L16_ClassWork_3_RectangleUtility
{
	public class Rectangle <T> where T: struct
	{
		public T SideA { get; private set; }
		public T SideB { get; private set; }
		public Rectangle(T sideA, T sideB)
		{
			SideA = sideA;
			SideB = sideB;
		}
		public T Calculate(Func<T, T, T> calculationLogic)
		{
			return calculationLogic(SideA, SideB);
		}
	}
}
