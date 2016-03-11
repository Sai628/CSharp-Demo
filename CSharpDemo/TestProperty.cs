using System;

namespace CSharpDemo
{
    public abstract class Person
    {
        public abstract string Name
        {
            get;
            set;
        }
        
        
        public abstract int Age
        {
            get;
            set;
        }
    }
    
    
    public class Student : Person
    {
        private string code = "N.A";
        private string name = "N.A";
        private int age = 0;
        
        
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
        
        
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        
        
        public override int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        
        
        public override string ToString()
        {
            return string.Format("Code:{0}, Name:{1}, Age:{2}", Code, Name, Age);
        }
    }
    
    
    public class TestProperty
    {
        public static void DoTest()
        {
            Student stu = new Student();
            stu.Code = "007";
            stu.Name = "Zara";
            stu.Age = 13;
            
            Console.WriteLine("Student Info: {0}", stu);
            
            stu.Age += 1;
            Console.WriteLine("Student Info: {0}", stu);
        }
    }    
}