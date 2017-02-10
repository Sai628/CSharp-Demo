using System;

namespace CSharpLearning
{
    class IndexedNames
    {
        public static int size = 10;
        private string[] nameList = new string[size];
        
        
        public IndexedNames()
        {
            for (int i = 0; i < size; i++)
            {
                nameList[i] = "N.A";
            }
        }
        
        
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < size)
                {
                    return nameList[index];
                }
                
                return "";
            }
            set
            {
                if (index >= 0 && index < size)
                {
                    nameList[index] = value;
                }
            }
        }
        
        
        public int this[string name]
        {
            get
            {
                int index = 0;
                while (index < size)
                {
                    if (nameList[index] == name)
                    {
                        return index;
                    }
                    
                    index++;
                }
                
                return -1;
            }
        }
    }
    
    
    public class TestIndexer
    {
        public static void DoTest()
        {
            IndexedNames names = new IndexedNames();
            names[0] = "Zara";
            names[1] = "Riz";
            names[2] = "Nuha";
            names[3] = "Asif";
            names[4] = "Davinder";
            names[5] = "Sunil";
            names[6] = "Rubic";
            
            for (int i = 0; i < IndexedNames.size; i++)
            {
                Console.WriteLine(names[i]);
            }
            // Zara
            // Riz
            // Nuha
            // Asif
            // Davinder
            // Sunil
            // Rubic
            // N.A
            // N.A
            // N.A
            
            Console.WriteLine(names["Nuha"]);  // 2
            Console.WriteLine(names["Sai"]);  // -1
        }
    }
}

