using System;

namespace CSharpLearning
{
    [AttributeUsage(AttributeTargets.Class |
    AttributeTargets.Constructor |
    AttributeTargets.Field |
    AttributeTargets.Method |
    AttributeTargets.Property,
    Inherited = false, AllowMultiple = true)]
    public class DeBugInfo : Attribute
    {
        private int bugNo;
        private string developer;
        private string lastReview;
        private string message;
        
        
        public DeBugInfo(int no, string dev, string last)
        {
            bugNo = no;
            developer = dev;
            lastReview = last;
        }
        
        
        public int BugNo
        {
            get 
            {
                return bugNo;
            }
        }
        
        
        public string Developer
        {
            get
            {
                return developer;
            }
        }
        
        
        public string LastReview
        {
            get
            {
                return lastReview;
            }
        }
        
        
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }
    }
    
    
    [DeBugInfo(45, "Zara Ali", "09/02/2016", Message = "Return type mismatch")]
    [DeBugInfo(49, "Nuha Ali", "10/02/2016", Message = "Unused Variable")]
    public class Rectangle3
    {
        protected double length;
        protected double width;
        
        
        public Rectangle3(double l, double w)
        {
            length = l;
            width = w;
        }
        
        
        [DeBugInfo(55, "Zara Ali", "14/02/2016", Message = "Return type mismatch")]
        public double GetArea()
        {
            return length * width;
        }
        
        
        [DeBugInfo(56, "Zara Ali", "16/02/2016")]
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    } 
    
    
    public class TestAttribute
    {
        public static void DoTest()
        {
            Rectangle3 rect = new Rectangle3(13, 14);
            rect.Display();
            // Length: 13
            // Width: 14
            // Area: 182
        }
    }
}
