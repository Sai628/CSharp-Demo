using System;
using System.Collections;

namespace CSharpDemo
{
    public class TestCollection
    {
        static void TestArrayList()
        {
            ArrayList list = new ArrayList();
        
            Console.WriteLine("Adding some numbers");
            list.Add(45);
            list.Add(77);
            list.Add(33);
            list.Add(56);
            list.Add(12);
            list.Add(23);
            list.Add(9);
            
            Console.WriteLine("Capacity: {0}", list.Capacity);
            Console.WriteLine("Count: {0}", list.Count);
            
            Console.WriteLine("Content: ");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            
            Console.WriteLine();
            Console.WriteLine("Sorted Content: ");
            list.Sort();
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        
        
        static void TestHashtable()
        {
            Hashtable table = new Hashtable();
            table.Add("001", "Zara Ali");
            table.Add("002", "Abida Rehman");
            table.Add("003", "Joe Holzner");
            table.Add("004", "Mausam Benazir Nur");
            table.Add("005", "M. Amlan");
            table.Add("006", "M. Arif");
            table.Add("007", "Ritesh Saikia");
            
            if (table.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("This student name is already in the table");
            }
            else
            {
                table.Add("008", "Nuha Ali");
            }
            
            ICollection keys = table.Keys;
            foreach (string key in keys)
            {
                Console.WriteLine(key + ": " + table[key]);
            }
            Console.WriteLine();
        }
        
        
        static void TestSortedList()
        {
            SortedList list = new SortedList();
            list.Add("001", "Zara Ali");
            list.Add("002", "Abida Rehman");
            list.Add("003", "Joe Holzner");
            list.Add("004", "Mausam Benazir Nur");
            list.Add("005", "M. Amlan");
            list.Add("006", "M. Arif");
            list.Add("007", "Ritesh Saikia");
            
            if (list.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("This student name is already in the table");
            }
            else
            {
                list.Add("008", "Nuha Ali");
            }
            
            ICollection keys = list.Keys;
            foreach (var key in keys)
            {
                Console.WriteLine(key + ": " + list[key]);
            }
            Console.WriteLine();
        }
        
        
        public static void TestStack()
        {
            Stack st = new Stack();
            st.Push("A");
            st.Push("M");
            st.Push("G");
            st.Push("W");
            
            Console.WriteLine("Current stack: ");
            foreach (string str in st)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
            
            st.Push("V");
            st.Push("H");
            Console.WriteLine("The next popable value in stack: {0}", st.Peek());
            
            Console.WriteLine("Current stack: ");
            foreach (string str in st)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
            
            Console.WriteLine("Removing values");
            st.Pop();
            st.Pop();
            st.Pop();
            
            Console.WriteLine("Current statck: ");
            foreach (string str in st)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
        }
        
        
        public static void TestQueue()
        {
            Queue q = new Queue();
            q.Enqueue("A");
            q.Enqueue("M");
            q.Enqueue("G");
            q.Enqueue("W");
            
            Console.WriteLine("Current queue: ");
            foreach (string str in q)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
            
            q.Enqueue("V");
            q.Enqueue("H");
            
            Console.WriteLine("Current queuen: ");
            foreach (string str in q)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
            
            Console.WriteLine("The removed value: {0}", q.Dequeue());
            Console.WriteLine("The removed value: {0}", q.Dequeue());
        }
        
        
        public static void TestBitArray()
        {
            BitArray ba1 = new BitArray(8);
            BitArray ba2 = new BitArray(8);
            
            byte[] a = {60};
            byte[] b = {13};
            ba1 = new BitArray(a);
            ba2 = new BitArray(b);
            
            Console.WriteLine("Bit array ba1: 60");
            for (int i = 0; i < ba1.Count; i++)
            {
                Console.Write("{0} ", ba1[i]);
            }
            Console.WriteLine();
            
            Console.WriteLine("Bit array ba2: 13");
            for (int i = 0; i < ba2.Count; i++)
            {
                Console.Write("{0} ", ba2[i]);
            }
            Console.WriteLine();
            
            BitArray ba3 = ba1.And(ba2);
            Console.WriteLine("Bit array ba3 after AND operation: 12");
            for (int i = 0; i < ba3.Count; i++)
            {
                Console.Write("{0} ", ba3[i]);
            }
            Console.WriteLine();
            
            BitArray ba4 = ba1.Or(ba2);
            Console.WriteLine("Bit array ba4 after OR operation: 61 {0}", ba4);
            for (int i = 0; i < ba4.Count; i++)
            {
                Console.Write("{0} ", ba4[i]);
            }
            Console.WriteLine();
        }
        
        
        public static void DoTest()
        {
            TestArrayList();
            TestHashtable();
            TestSortedList();
            TestStack();
            TestQueue();
            TestBitArray();
        }
    }
}


