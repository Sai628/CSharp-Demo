using System;
using System.IO;

namespace CSharpDemo
{
    public delegate int NumberChanger(int n);
    public delegate void PrintString(string s);
    
    
    public class TestDelegate
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
        
        
        public static void WriteToScreen(string str)
        {
            Console.WriteLine("The string is: {0}", str);
        }
        
        
        public static void WriteToFile(string str)
        {
            string filePath = Directory.GetCurrentDirectory() + "/CSharpDemo/bin/Debug/message.txt";
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        
        
        public static void sendString(PrintString ps)
        {
            ps("Hello World!");
        }
        
        
        public static void DoTest()
        {
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);
            NumberChanger nc = nc1 + nc2;
            
            nc(5);
            Console.WriteLine("value of Num: {0}", GetNum());
            
            nc1(25);
            Console.WriteLine("value if Num: {0}", GetNum());
            nc2(5);
            Console.WriteLine("value of Num: {0}", GetNum());
            
            PrintString ps1 = new PrintString(WriteToScreen);
            PrintString ps2 = new PrintString(WriteToFile);
            sendString(ps1);
            sendString(ps2);
        }
    }
}


