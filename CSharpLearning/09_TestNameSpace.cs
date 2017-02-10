using System;
using FirstSpace;
using FirstSpace.SecondSpace;

namespace FirstSpace
{
    class A
    {
        public void Func()
        {
            Console.WriteLine("Inside first space");
        }
    }
    
    
    namespace SecondSpace
    {
        class B
        {
            public void Func()
            {
                Console.WriteLine("Inside second space");
            }
        }
    }
}


namespace CSharpLearning
{
    public class TestNameSpace
    {
        public static void DoTest()
        {
            A a = new A();
            B b = new B();
            a.Func();  // Inside first space
            b.Func();  // Inside second space
        }
    }
}


