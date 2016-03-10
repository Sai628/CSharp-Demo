using System;

namespace CSharpDemo
{
    public class TestString
    {
        public static void doTest()
        {
            string fname = "Rowan";
            string lname = "Atkinson";
            string fullname = fname + " " + lname;
            Console.WriteLine("Full Name:{0}", fullname);
            
            char[] letters = {'H', 'e', 'l', 'l', '0'};
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);
            
            string[] sarray = {"Hello", "From", "Tutorials", "Point"};
            string message = String.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);
            
            DateTime dateTime = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", dateTime);
            Console.WriteLine("Message: {0}", chat);
        }
    }
}