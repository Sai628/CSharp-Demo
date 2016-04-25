using System;

namespace CSharpDemo
{
    public class TestEnum
    {
        enum Days
        {
            Sun, Mon, Tue, Wed, Thu, Fri, Sat
        }
        
        
        public static void DoTest()
        {
            int weekDayStart = (int)Days.Mon;
            int weekDayEnd = (int)Days.Fri;
            Console.WriteLine("Monday: {0}", weekDayStart);  // Monday: 1
            Console.WriteLine("Friday: {0}", weekDayEnd);  // Friday: 5
        }
    }
}