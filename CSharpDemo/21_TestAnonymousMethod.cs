using System;

namespace CSharpDemo
{
    delegate void NumberChangerDelegate(int n);
    
    
    class DelegateClass2
    {
        static int num = 10;
        
        
        public static void AddNum(int n)
        {
            num += n;
            Console.WriteLine("Named Method: {0}", num);
        }
        
        
        public static void MutlNum(int n)
        {
            num *= n;
            Console.WriteLine("Named Method: {0}", num);
        }
        
        
        public static int GetNum()
        {
            return num;
        }
    }
    
    
    public class TestAnonymousMethod
    {
        public static void DoTest()
        {
            NumberChangerDelegate nc = delegate(int n)
            {
                Console.WriteLine("Anonymous Method: {0}", n);
            };
            nc(10);  // Anonymous Method: 10
            
            nc = new NumberChangerDelegate(DelegateClass2.AddNum);
            nc(5);  // Named Method: 15
            
            nc = new NumberChangerDelegate(DelegateClass2.MutlNum);
            nc(10);  // Named Method: 150
        }
    }
}


