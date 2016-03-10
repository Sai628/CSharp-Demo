using System;

namespace CSharpDemo
{
    class DivNumbers
    {
        int result;
        
        
        public DivNumbers()
        {
            result = 0;
        }
        
        
        public void divison(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }
    }
    
    
    class TempIsZeroException : ApplicationException
    {
        public TempIsZeroException(string message) : base(message)
        {
        }
    }
    
    
    class Temperature
    {
        int temperature = 0;
        
        
        public void ShowTemp()
        {
            if (temperature == 0)
            {
                throw new TempIsZeroException("Zero Temperature found");
            }
            else
            {
                Console.WriteLine("Temperature: {0}", temperature);
            }
        }
    }
    
    
    public class TestException
    {
        public static void DoTest()
        {
            DivNumbers div = new DivNumbers();
            div.divison(12, 0);
            
            Temperature temp = new Temperature();
            try
            {
                temp.ShowTemp();
            }
            catch (TempIsZeroException e)
            {
                Console.WriteLine("TempIsZeroException: {0}", e.Message);
            }
        }
    }
}

