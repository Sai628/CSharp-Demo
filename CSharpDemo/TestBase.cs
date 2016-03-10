using System;

namespace CSharpDemo
{
    public class TestBase
    {
        public static void doTest()
        {
            int a = 100;
    		int b = 200;
            
            Console.WriteLine("{0}, {1}", a, b);
			TestBase.swap(ref a, ref b);
			Console.WriteLine("{0}, {1}", a, b);

			int c, d;
			TestBase.getValue(out c, out d);
			Console.WriteLine("{0}, {1}", c, d);

			int? num1 = null;
			int? num2 = 45;
			double? num3 = new double?();
			double? num4 = 3.14159;
			bool? boolValue = new bool?();

			double num5;
			num5 = num3 ?? 5.34;

			Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", num1, num2, num3, num4, boolValue, num5);
        }
        
        
        public static int factorial(int num)
		{
			return (num == 1 ? 1 : factorial(num - 1) * num);
		}

		public static void swap(ref int x, ref int y)
		{
			int temp = x;
			x = y;
			y = temp;
		}


		public static void getValue(out int x, out int y)
		{
			x = 12;
			y = 13;
		}
    }
}