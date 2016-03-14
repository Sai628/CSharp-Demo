using System;
using System.Collections.Generic;

namespace CSharpDemo
{
    public delegate T NumberChangerWithGeneric<T>(T n);
    
    
    public class MyGenericClass<T>
    {
        private T[] array;
        
        
        public MyGenericClass(int size)
        {
            array = new T[size + 1];
        }
        
        
        public T GetItem(int index)
        {
            return array[index];
        }
        
        
        public void SetItem(int index, T item)
        {
            array[index] = item;
        }
    }
    
    
    public class DelegateClass
    {
        static int num = 10;
        
        
        public static int AddNum(int n)
        {
            num += n;
            return num;
        }
        
        
        public static int MultNum(int n)
        {
            num *= n;
            return num;
        }
        
        
        public static int GetNum()
        {
            return num;
        }
    }
    
    
    public class TestGeneric
    {
        static void Swap<T>(ref T left, ref T right)
        {
            T temp;
            temp = left;
            left = right;
            right = temp;
        }
        
        
        public static void DoTest()
        {
            int size = 5;
            
            MyGenericClass<int> intArray = new MyGenericClass<int>(size);
            for (int i = 0; i < size; i++)
            {
                intArray.SetItem(i, i * 10);
            }
            
            for (int i = 0; i < size; i++)
            {
                Console.Write(intArray.GetItem(i) + " ");
            }
            Console.WriteLine();
            
            
            MyGenericClass<char> charArray = new MyGenericClass<char>(size);
            for (int i = 0; i < size; i++)
            {
                charArray.SetItem(i, (char)(i+97));
            }
            
            for (int i = 0; i < size; i++)
            {
                Console.Write(charArray.GetItem(i) + " ");
            }
            Console.WriteLine();
            
            int a = 10;
            int b = 20;
            char c = 'i';
            char d = 'j';
            Console.WriteLine("Int value before calling swap: a={0}, b={1}", a, b);
            Console.WriteLine("Char value before calling swap: c={0}, d={1}", c, d);
            
            Swap<int>(ref a, ref b);
            Swap<char>(ref c, ref d);
            
            Console.WriteLine("Int value after calling swap: a={0}, b={1}", a, b);
            Console.WriteLine("Char value after calling swap: c={0}, d={1}", c, d);
            Console.WriteLine();
            
            var nc1 = new NumberChangerWithGeneric<int>(DelegateClass.AddNum);
            var nc2 = new NumberChangerWithGeneric<int>(DelegateClass.MultNum);
            nc1(25);
            Console.WriteLine("Value of Num: {0}", DelegateClass.GetNum());
            nc2(5);
            Console.WriteLine("Value of Num: {0}", DelegateClass.GetNum());
        }
    }
}


