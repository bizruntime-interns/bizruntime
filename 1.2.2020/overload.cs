using System;
namespace overloading
{
	class program
	{
		public static int intadd(int x, int y)
		{
			return x + y;
		}
		public static double doubleadd(double x, double y)
		{
			return x + y;
		}
		static void Main(string[] args)
		{
			int num1 = intadd(8, 9);
			double num2 = doubleadd(4.8, 5.7);
			Console.WriteLine("addition of 8 and 9 in int is:" + num1);
			Console.WriteLine("addition of 4.8 and 5.7 in double is:" + num2);
		}
	}
}



