using System;
using System.IO;

namespace CSharpDemo
{
    public class TestFileIO
    {
        public static void DoTest()
        {
            string filePath = Directory.GetCurrentDirectory() + "/CSharpDemo/bin/Debug/test.dat";
            FileStream file = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            
            for (int i = 0; i <= 20; i++)
            {
                file.WriteByte((byte)i);
            }
            
            file.Position = 0;
            
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(file.ReadByte() + " ");  // 0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 
            }
            Console.WriteLine();
            file.Close();
            
            filePath = Directory.GetCurrentDirectory() + "/CSharpDemo/bin/Debug/name.txt";
            using(StreamWriter sw = new StreamWriter(filePath))
            {
                string[] names = {"Zara Ali", "Nuha Ali"};
                foreach (string s in names)
                {
                    sw.WriteLine(s);
                }
            }
            
            using(StreamReader sr = new StreamReader(filePath))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    // Zara Ali
                    // Nuha Ali
                }
            }
            
            
            DirectoryInfo myDir = new DirectoryInfo(Directory.GetCurrentDirectory() + "/CSharpDemo/bin/Debug/");
            FileInfo[] files = myDir.GetFiles();
            foreach (FileInfo fileInfo in files)
            {
                Console.WriteLine("File Name: {0} Size: {1}", fileInfo.Name, fileInfo.Length);
            }
            // File Name: CSharpDemo.exe Size: 32768
            // File Name: CSharpDemo.exe.mdb Size: 14047
            // File Name: name.txt Size: 18
            // File Name: test.dat Size: 21
        }
    }
}

