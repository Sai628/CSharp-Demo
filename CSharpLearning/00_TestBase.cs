using System;

namespace CSharpLearning
{
    public class TestBase
    {
        public static void DoTest()
        {
            int a = 100;
            int b = 200;
            
            Console.WriteLine("{0}, {1}", a, b);  // 100, 200
            TestBase.Swap(ref a, ref b);
            Console.WriteLine("{0}, {1}", a, b);  // 200, 100

            int c, d;
            TestBase.GetValue(out c, out d);
            Console.WriteLine("{0}, {1}", c, d);  //12, 13

            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14159;
            bool? boolValue = new bool?();

            double num5;
            num5 = num3 ?? 5.34;

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", num1, num2, num3, num4, boolValue, num5);  // , 45, , 3.14159, , 5.34
        }
        
        
        public static int Factorial(int num)
        {
            return (num == 1 ? 1 : Factorial(num - 1) * num);
        }


        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }


        public static void GetValue(out int x, out int y)
        {
            x = 12;
            y = 13;
        }
    }
}