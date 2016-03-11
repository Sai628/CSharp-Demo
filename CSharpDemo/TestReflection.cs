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


namespace CSharpDemo
{
    public class TestReflection
    {
        public static void DoTest()
        {
            MemberInfo info = typeof(MyClass);
            object[] attributes = info.GetCustomAttributes(true);
            foreach (var attr in attributes)
            {
                Console.WriteLine(attr);
            }
            
            Rectangle3 rect = new Rectangle3(12, 24);
            rect.Display();
            
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
            }
        }
    }    
}


