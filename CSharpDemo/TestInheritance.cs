using System;

namespace CSharpDemo
{
    class Shape
    {
        protected int width;
        protected int height;
        
        
        public void SetWidth(int w)
        {
            width = w;
        }
        
        
        public void SetHeight(int h)
        {
            height = h;    
        }
    }
    
    
    interface IPaintCost
    {
        int GetCost(int area);
    }
    
    
    class Rectangle: Shape, IPaintCost
    {
        public int GetArea()
        {
            return (width * height);
        }
        
        
        public int GetCost(int area)
        {
            return (area * 70);
        }
        
        
        public void Display()
        {
            Console.WriteLine("width: {0}", width);
            Console.WriteLine("height: {0}", height);
            Console.WriteLine("area: {0}", GetArea());
        }
    }
    
    
    class TestInheritance
    {
        public static void DoTest()
        {
    	   Rectangle rect = new Rectangle();
           rect.SetWidth(5);
           rect.SetHeight(7);
           
           Console.WriteLine("area: {0}", rect.GetArea()); 
           Console.WriteLine("cost: {0}", rect.GetCost(rect.GetArea()));        
        }
    }
}