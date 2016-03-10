using System;

namespace CSharpDemo
{
    class Box
    {
        private double length;
        private double breadth;
        private double height;
        
        
        public double GetVolumn()
        {
            return (length * breadth * height);
        }
        
        
        public void SetLength(double len)
        {
            length = len;
        }
        
        
        public void SetBreadth(double bre)
        {
            breadth = bre;
        }
        
        
        public void SetHeight(double h)
        {
            height = h;
        }
        
        
        public override bool Equals (object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            
            Box box = obj as Box;
            return (length == box.length && breadth == box.breadth && height == box.height);
        }
        
        
        public override int GetHashCode()
        {
            return ((int)length ^ (int)breadth ^ (int)height);
        }
        
        
        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            
            return box;
        }
        
        
        public static bool operator ==(Box b, Box c)
        {
            return (b.length == c.length && b.breadth == c.breadth && b.height == c.height);
        }
        
        
        public static bool operator !=(Box b, Box c)
        {
            return (b.length != c.length || b.breadth != c.breadth || b.height != c.height);
        }
        
        
        public static bool operator <(Box leftBox, Box rightBox)
        {
            return (leftBox.length < rightBox.length && leftBox.breadth < rightBox.breadth && leftBox.height < rightBox.height);
        }
        
        
        public static bool operator >(Box leftBox, Box rightBox)
        {
            return (leftBox.length > rightBox.length && leftBox.breadth > rightBox.breadth && leftBox.height > rightBox.height);
        }
        
        
        public static bool operator <=(Box leftBox, Box rightBox)
        {
            return (leftBox.length <= rightBox.length && leftBox.breadth <= rightBox.breadth && leftBox.height <= rightBox.height);
        }
        
        
        public static bool operator >=(Box leftBox, Box rightBox)
        {
            return (leftBox.length >= rightBox.length && leftBox.breadth >= rightBox.breadth && leftBox.height >= rightBox.height);
        }
        
        
        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", length, breadth, height);
        }
    }
    
    
    public class TestOperatorOvl
    {
        public static void DoTest()
        {
            Box box1 = new Box();
            Box box2 = new Box();
            Box box3 = new Box();
            Box box4 = new Box();
            
            box1.SetLength(6.0);
            box1.SetBreadth(7.0);
            box1.SetHeight(5.0);
            
            box2.SetLength(12.0);
            box2.SetBreadth(13.0);
            box2.SetHeight(10.0);
            
            Console.WriteLine("box1: {0}", box1.ToString());
            Console.WriteLine("box1 volumn: {0}", box1.GetVolumn());
            Console.WriteLine("box2: {0}", box2.ToString());
            Console.WriteLine("box2 volumn: {0}", box2.GetVolumn());
            
            box3 = box1 + box2;
            Console.WriteLine("box3: {0}", box3.ToString());
            Console.WriteLine("box3 volumn: {0}", box3.GetVolumn());
            
            if (box1 > box2)
            {
                Console.WriteLine("box1 > box2");
            }
            else
            {
                Console.WriteLine("box1 <= box2");
            }
            
            if (box1 < box2)
            {
                Console.WriteLine("box1 < box2");
            }
            else
            {
                Console.WriteLine("box1 >= box2");
            }
            
            if (box1 >= box2)
            {
                Console.WriteLine("box1 >= box2");
            }
            else
            {
                Console.WriteLine("box1 < box2");
            }
            
            if (box1 <= box2)
            {
                Console.WriteLine("box1 <= box2");
            }
            else
            {
                Console.WriteLine("box1 > box2");
            }
            
            if (box1 != box2)
            {
                Console.WriteLine("box1 != box2");
            }
            else
            {
                Console.WriteLine("box1 == box2");
            }
            
            if (box1 == box2)
            {
                Console.WriteLine("box1 == box2");
            }
            else
            {
                Console.WriteLine("box1 != box2");
            }
            
            box4 = box3;
            if (box3 == box4)
            {
                Console.WriteLine("box3 == box4");
            }
            else
            {
                Console.WriteLine("box3 != box4");
            }
        }
    }
}