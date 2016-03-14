using System;

namespace CSharpDemo
{
    public class TestUnsafeCode
    {
        static unsafe void TestUnsafeMethod()
        {
            int a = 20;
            int* p = &a;
            Console.WriteLine("Data is: {0}", a);
            Console.WriteLine("Address is: {0}", (int)p);
        }
        
        
        unsafe static void Swap(int* p, int* q)
        {
            int temp = *p;
            *p = *q;
            *q = temp;
        }
        
        
        public static void DoTest()
        {
            TestUnsafeMethod();
            
            unsafe
            {
                int a = 20;
                int*p = &a;
                Console.WriteLine("Data is: {0}", a);
                Console.WriteLine("Data is: {0}", p->ToString());
                Console.WriteLine("Address is: {0}", (int)p);
            }
            
            unsafe
            {
                int var1 = 10;
                int var2 = 20;
                int* x = &var1;
                int* y = &var2;
                Console.WriteLine("Before swap values: {0}, {1}", var1, var2);
                Swap(x, y);
                Console.WriteLine("After swap values: {0}, {1}", var1, var2);       
            }
            
            unsafe
            {
                int[] list = {10, 20, 30};
                fixed(int* ptr = list)
                
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Address of list[{0}]={1}", i, (int)(ptr + i));
                    Console.WriteLine("Value of list[{0}]={1}", i, *(ptr + i));
                }
            }
        }
    }    
}


