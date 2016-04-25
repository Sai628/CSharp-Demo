using System;

namespace CSharpDemo
{
    public interface ITransactions
    {
        void ShowTransaction();
        double GetAmout();
    }


    class Transaction : ITransactions
    {
        private string tCode;
        private string date;
        private double amount;
        
        
        public Transaction()
        {
            tCode = "";
            date = "";
            amount = 0.0;
        }
        
        
        public Transaction(string c, string d, double a)
        {
            tCode = c;
            date = d;
            amount = a;
        }
        
        
        public double GetAmout()
        {
            return amount;
        }

        public void ShowTransaction()
        {
            Console.WriteLine("Transaction: {0}", tCode);
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("Amount: {0}", amount);
        }
    }
    
    
    public class TestInterface
    {
        public static void DoTest()
        {
            Transaction t1 = new Transaction("001", "8/02/2016", 10000.00);
            Transaction t2 = new Transaction("002", "2/03/2016", 12000.00);
            
            t1.ShowTransaction();
            t2.ShowTransaction();
            
            // Transaction: 001
            // Date: 8/02/2016
            // Amount: 10000
            // Transaction: 002
            // Date: 2/03/2016
            // Amount: 12000
        }
    }
}