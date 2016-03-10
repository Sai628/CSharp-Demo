using System;

namespace CSharpDemo
{
    struct Books
    {
        private string _title;
        private string _author;
        private string _subject;
        private int _book_id;
        
     
        public void setValues(string title, string author, string subject, int book_id)
        {
            _title = title;
            _author = author;
            _subject = subject;
            _book_id = book_id;
        }
        
        
        public void display()
        {
            Console.WriteLine("title: {0}", _title);
            Console.WriteLine("author: {0}", _author);
            Console.WriteLine("subject: {0}", _subject);
            Console.WriteLine("book_id: {0}", _book_id);
        }   
    }
    
    
    public class TestStruct
    {
        public static void doTest()
        {
            Books book1 = new Books();
            Books book2 = new Books();
            
            book1.setValues("C Programming", "Nuha Ali", "C Programming Tutorial", 6495407);
            book2.setValues("Telecom Billing", "Zara Ali", "Telecom Billing Tutorial", 6495700);
            
            book1.display();
            book2.display();
        }
    }
}