using System;
using System.IO;

namespace CSharpDemo
{
    public class TestFileIO
    {
        public static void DoTest()
        {
            FileStream file = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            
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
            
            string[] names = {"Zara Ali", "Nuha Ali"};
            string fileName = "name.txt";
            using(StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (string s in names)
                {
                    sw.WriteLine(s);
                }
            }
            
            string line = "";
            using(StreamReader sr = new StreamReader(fileName))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            
            
            DirectoryInfo myDir = new DirectoryInfo(@"./");
            FileInfo[] files = myDir.GetFiles();
            foreach (FileInfo fileInfo in files)
            {
                Console.WriteLine("File Name: {0} Size: {1}", fileInfo.Name, fileInfo.Length);
            }
        }
    }
}

