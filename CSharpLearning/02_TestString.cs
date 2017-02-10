using System;

namespace CSharpLearning
{
    public class TestString
    {
        public static void DoTest()
        {
            string fname = "Rowan";
            string lname = "Atkinson";
            string fullname = fname + " " + lname;
            Console.WriteLine("Full Name:{0}", fullname);  // Full Name:Rowan Atkinson
            
            char[] letters = {'H', 'e', 'l', 'l', '0'};
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);  // Greetings: Hell0
            
            string[] sarray = {"Hello", "From", "Tutorials", "Point"};
            string message = String.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);  // Message: Hello From Tutorials Point
            
            DateTime dateTime = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", dateTime);
            Console.WriteLine("Message: {0}", chat);  // Message: Message sent at 5:58 PM on Wednesday, October 10, 2012
        }
    }
}