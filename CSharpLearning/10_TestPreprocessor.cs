#define PI
#define DEBUG
#define VC_V10

using System;

namespace CSharpLearning
{
    public class TestPreprocessor
    {
        public static void DoTest()
        {
            #if (PI)
            {
                Console.WriteLine("PI is defined");  // PI is defined
            }
            #else
            {
                Console.WriteLine("PI is not defined");
            }
            #endif
            
            #if (DEBUG && !VC_V10)
            {
                Console.WriteLine("DEBUG is defined");
            }
            #elif (!DEBUG && VC_V10)
            {
                Console.WriteLine("VC_V10 is defined");
            }
            #elif (DEBUG && VC_V10)
            {
                Console.WriteLine("DEBUG and VC_V10 are defined");  // DEBUG and VC_V10 are defined
            }
            #else
            {
                Console.WriteLine("DEBUG and VC_V10 are not defined");
            }
            #endif
        }
    }    
}

