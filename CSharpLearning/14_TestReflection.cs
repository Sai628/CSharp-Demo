using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.All)]
public class HelpAttribute : Attribute
{
    public readonly string url;
    private string topic;
    
    
    public HelpAttribute(string url)
    {
        this.url = url;
    }
    
    
    public string Topic
    {
        get
        {
            return topic;
        }
        set
        {
            topic = value;
        }
    }
}


[HelpAttribute("Information on the class MyClass")]
class MyClass
{
}


namespace CSharpLearning
{
    public class TestReflection
    {
        public static void DoTest()
        {
            MemberInfo info = typeof(MyClass);
            object[] attributes = info.GetCustomAttributes(true);
            foreach (var attr in attributes)
            {
                Console.WriteLine(attr);  // HelpAttribute
            }
            
            Rectangle3 rect = new Rectangle3(12, 24);
            rect.Display();
            // Length: 12
            // Width: 24
            // Area: 288
            
            
            Type type = typeof(Rectangle3);
            foreach (var attr in type.GetCustomAttributes(false))
            {
                DeBugInfo bugInfo = attr as DeBugInfo;
                if (bugInfo != null)
                {
                    Console.WriteLine("Bug No: {0}", bugInfo.BugNo);
                    Console.WriteLine("Developer: {0}", bugInfo.Developer);
                    Console.WriteLine("Last Review: {0}", bugInfo.LastReview);
                    Console.WriteLine("Remarks: {0}", bugInfo.Message);
                }
            }
            // Bug No: 45
            // Developer: Zara Ali
            // Last Review: 09/02/2016
            // Remarks: Return type mismatch
            
            // Bug No: 49
            // Developer: Nuha Ali
            // Last Review: 10/02/2016
            // Remarks: Unused Variable
            
            
            foreach (var method in type.GetMethods())
            {
                foreach (var attr in method.GetCustomAttributes(true))
                {
                    DeBugInfo bugInfo = attr as DeBugInfo;
                    if (bugInfo != null)
                    {
                        Console.WriteLine("Bug No: {0}", bugInfo.BugNo);
                        Console.WriteLine("Developer: {0}", bugInfo.Developer);
                        Console.WriteLine("Last Review: {0}", bugInfo.LastReview);
                        Console.WriteLine("Remarks: {0}", bugInfo.Message);
                    }
                }
                // Bug No: 55
                // Developer: Zara Ali
                // Last Review: 14/02/2016
                // Remarks: Return type mismatch
                
                // Bug No: 56
                // Developer: Zara Ali
                // Last Review: 16/02/2016
                // Remarks: 
            }
        }
    }    
}


