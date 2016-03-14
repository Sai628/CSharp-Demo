using System;
using System.Threading;

namespace CSharpDemo
{
    public class TestThread
    {
        public static void CallInChildThread()
        {
            try
            {
                Console.WriteLine("Child thread starts...");
                for (int counter = 0; counter <= 10; counter++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine(counter);
                }
                Console.WriteLine("Child thread Completed.");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("Thread Abort Exception");
            }
            finally
            {
                Console.WriteLine("Couldn't catch the thread Exception");
            }
        }
        
        
        public static void DoTest()
        {
            Thread th = Thread.CurrentThread;
            th.Name = "MainThread";
            Console.WriteLine("This is {0}", th.Name);
            
            ThreadStart childRef = new ThreadStart(CallInChildThread);
            Console.WriteLine("In Main: Creating the child thread");
            
            Thread childThread = new Thread(childRef);
            childThread.Start();
            
            Thread.Sleep(2000);
            Console.WriteLine("In Main: Aborting the child thread");
            
            childThread.Abort();
        }
    }    
}


