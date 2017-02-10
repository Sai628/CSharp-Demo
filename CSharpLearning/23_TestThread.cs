using System;
using System.Threading;

namespace CSharpLearning
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
                Console.WriteLine("Thread Abort Exception: {0}", e);
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
            Console.WriteLine("This is {0}", th.Name);  // This is MainThread
            
            ThreadStart childRef = new ThreadStart(CallInChildThread);
            Console.WriteLine("In Main: Creating the child thread");
            
            Thread childThread = new Thread(childRef);
            childThread.Start();
            // Child thread starts...
            // 0
            // 1
            // 2
            
            Thread.Sleep(2000);
            Console.WriteLine("In Main: Aborting the child thread");  // In Main: Aborting the child thread
            
            childThread.Abort();
        }
    }    
}


