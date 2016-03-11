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
                Console.Write(file.ReadByte() + " ");
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
                }
            }
            
            
            DirectoryInfo myDir = new DirectoryInfo(Directory.GetCurrentDirectory() + "/CSharpDemo/bin/Debug/");
            FileInfo[] files = myDir.GetFiles();
            foreach (FileInfo fileInfo in files)
            {
                Console.WriteLine("File Name: {0} Size: {1}", fileInfo.Name, fileInfo.Length);
            }
        }
    }
}

