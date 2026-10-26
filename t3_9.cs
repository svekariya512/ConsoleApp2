using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //9. Write a program to demonstrate the use of static, this, base, and new keywords using
    //suitable classes related to a library management system.Display the result of each operation.
    class Library
    {
        public static string libraryName = "RKU Library";

        protected int bookid;
        protected string booktitle;

        public Library(int id, string title)
        {
            bookid = id;
            booktitle = title;
        }
        public void showlibrary()
        {
            Console.WriteLine("Library Name: " + libraryName);


        }
        public void Display()
        {
            Console.WriteLine("Book ID: " + bookid);
            Console.WriteLine("Book Title: " + booktitle);
        }
    }


        class Books : Library
    {
        private string author;
        public Books(int id, string title, string auth) : base(id, title)
        {
            this.author = auth;
        }
        public new void Display()
        {
            base.Display();
            Console.WriteLine("Author: " + author);
        }
    }

 class t3_9
        {
            static void Main(string[] args)
        {
            Console.WriteLine("Name : Shreeya Vekariya");
            Console.WriteLine("Roll No : 24SOECE11050");
            
            Books b1 = new Books(101, "C# Programming", "Shreeya");
            b1.Display();
            b1.showlibrary();

            Console.ReadLine();
        }

    
    }
}
