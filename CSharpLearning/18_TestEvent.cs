using System;
using System.IO;

namespace CSharpLearning
{
    class Boiler
    {
        private int temp;
        private int pressure;
        
        
        public Boiler(int t, int p)
        {
            temp = t;
            pressure = p;
        }
        
        
        public int GetTemp()
        {
            return temp;
        }
        
        
        public int GetPressure()
        {
            return pressure;
        }
    }
    
    
    class DelegateBoilerEvent
    {
        public delegate void BoilerLogHandler(string status);
        public event BoilerLogHandler BoilerEventLog;
        
        
        public void LogProcess()
        {
            string remarks = "O.K";
            Boiler b = new Boiler(100, 12);
            int t = b.GetTemp();
            int p = b.GetPressure();
            if (t > 150 || t < 80 || p < 12 || p > 15)
            {
                remarks = "Need Maintenance";
            }
            
            OnBoilerEventLog("Logging Info:\n");
            OnBoilerEventLog("Temparature: " + t + "\nPressure: " + p);
            OnBoilerEventLog("\nMessage: " + remarks);
        }
        
        
        protected void OnBoilerEventLog(string message)
        {
            if (BoilerEventLog != null)
            {
                BoilerEventLog(message);
            }
        }
    }
    
    
    class BoilerInfoLogger
    {
        FileStream fs;
        StreamWriter sw;
        
        
        public BoilerInfoLogger(string fileName)
        {
            fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
        }
        
        
        public void Logger(string info)
        {
            sw.WriteLine(info);
        }
        
        
        public void Close()
        {
            sw.Close();
            fs.Close();
        }
    }
    
    
    public class TestEvent
    {
        static void Logger(string info)
        {
            Console.WriteLine(info);
        }
        
        public static void DoTest()
        {
            string filePath = Directory.GetCurrentDirectory() + "/CSharpLearning/bin/Debug/info.txt";
            BoilerInfoLogger fileLog = new BoilerInfoLogger(filePath);
            
            DelegateBoilerEvent boilerEvent = new DelegateBoilerEvent();
            boilerEvent.BoilerEventLog += new DelegateBoilerEvent.BoilerLogHandler(Logger);
            boilerEvent.BoilerEventLog += new DelegateBoilerEvent.BoilerLogHandler(fileLog.Logger);
            
            boilerEvent.LogProcess();
            fileLog.Close();
            
            // Logging Info:
            // Temparature: 100
            // Pressure: 12
            // Message: O.K
        }
    }    
}


