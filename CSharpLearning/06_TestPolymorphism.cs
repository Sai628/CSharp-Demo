using System;

namespace CSharpLearning
{
    class Printdata
    {
        public void Print(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }
        
        
        public void Print(double d)
        {
            Console.WriteLine("Printing double: {0}", d);
        }
        
        
        public void Print(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }
    }
    
    
    class Shape2
    {
        protected int width;
        protected int height;
        
        
        public Shape2(int w=0, int h=0)
        {
            width = w;
            height = h;
        }
        
        
        public virtual int GetArea()
        {
            return 0;
        }
    }
    
    
    class Rectangle2 : Shape2
    {
        public Rectangle2(int w=0, int h=0) : base(w, h)
        {}
        
        
        public override int GetArea()
        {
            return (width * height);
        }
    }
    
    
    class Triangle : Shape2
    {
        public Triangle(int w=0, int h=0) : base(w, h)
        {}
        
        
        public override int GetArea()
        {
            return (width * height / 2);
        }
    }
    
    
    class Caller
    {
        public void CallArea(Shape2 shape)
        {
            Console.WriteLine("area: {0}", shape.GetArea());
        }
    }
    
    
    public class TestPolymorphism
    {
        public static void DoTest()
        {
            Printdata print = new Printdata();
            print.Print(5);  // Printing int: 5
            print.Print(3.0);  // Printing double: 3
            print.Print("Hello C#");  // Printing string: Hello C#
            
            Rectangle2 rect = new Rectangle2(10, 7);
            Triangle tri = new Triangle(12, 8);
            Caller c = new Caller();
            c.CallArea(rect);  // area: 70
            c.CallArea(tri);  // area: 48
        }
    }
}
